#include "helloworld.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conformant;
	Evas_Object *naviframe;
	Evas_Object *label;
	Evas_Object *label2;
	Evas_Object *popup;
} appdata_s;

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	   elm_exit();

		//evas_object_show(ad->label2);
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;

	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
clicked_cb_close(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	elm_popup_timeout_set(ad->popup, 0.1);
}
static void
create_popup(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;


	ad->popup = elm_popup_add(ad->naviframe);
	elm_popup_align_set(ad->popup, ELM_NOTIFY_ALIGN_FILL, 1.0);
	eext_object_event_callback_add(ad->popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, ad);
	evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_text_set(ad->popup, "SSID : IITH Guest\n    \t                        RSSI : -10dBm\n                        Channel :11");

	evas_object_show(ad->popup);

	Evas_Object *button1;
	button1 = elm_button_add(ad->popup);
	elm_object_text_set(button1, "OK");
	elm_object_part_content_set(ad->popup, "button1", button1);

	evas_object_smart_callback_add(button1, "clicked", clicked_cb_close, ad);


}


static void
clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	Evas_Object *bg=elm_bg_add(ad->naviframe);
		elm_bg_color_set(bg,66,153,206);
		elm_naviframe_item_push(ad->naviframe,"Info About access points",NULL,NULL,bg,NULL);
		Evas_Object *box = elm_box_add(ad->naviframe);

			   // Set the box vertical
			   elm_box_horizontal_set(box, EINA_FALSE);

			   elm_box_padding_set(box,10,10);

			   // The box expands when its contents need more space
			   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

			   // The box fills the available space
			   evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

			   // Add the box in the naviframe container
			   elm_naviframe_item_push(ad->naviframe, "Info About access points", NULL, NULL, box, NULL);

			   // Show the box
			   evas_object_show(box);

		Evas_Object *button = elm_button_add(box);

			   // The box expands when its contents need more space
			   evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

			   // The button fills the available space on the horizontal axis and is
			   // placed at the bottom of the vertical axis (1 is the end of the axis,
			   // the coordinates start at (0, 0) on the top-left corner
			   evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

			   //evas_object_size_hint_min_set(button, 128, 128);

			   // Set the text for the button
			   elm_object_text_set(button, "close");

			   // Add a callback on the button for the "clicked" event; implementation of
			   // the callback is below
			   evas_object_smart_callback_add(button, "clicked", clicked_cb_close, ad);


			   // Add the UI component at the end of the box; since the axis starts in the top left
			   // corner and the box is vertical, the end of the box is below the label
			   elm_box_pack_end(box, button);
			   evas_object_show(button);

   //elm_exit();


}

static void
create_base_gui(appdata_s *ad)
{
	   Evas_Object *box1,*box2,*btn1;
	// Create the window
	   ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	   elm_win_conformant_set(ad->win, EINA_TRUE);

	   // Advertise which rotations are supported by the application; the
	   // device_orientation callback is used to do the actual rotation when
	   // the system detects the device's orientation has changed
	   if (elm_win_wm_rotation_supported_get(ad->win))
	   {
	      int rots[4] = {0, 90, 180, 270};
	      elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	   }

	   // Add a callback on the "delete,request" event; it is emitted when
	   // the system closes the window
	   evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	   //eext_object_event_callback_add(ad->win,EEXT_CALLBACK_BACK,win_back_cb,ad);

	   // Alternatively, elm_win_autodel_set() can be used to close
	   // the window (not the application) automatically
	   // with the Back button, for example
	   // elm_win_autodel_set(ad->win, EINA_TRUE);
	   // Create the conformant
	   ad->conformant = elm_conformant_add(ad->win);

	   // Set the conformant use as much horizontal and vertical space as
	   // possible, that is, expand in both directions
	   evas_object_size_hint_weight_set(ad->conformant, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	   // Set the conformant as the resize object for the window:
	   // the window and the conformant grow together
	   // in proportion to each other
	   elm_win_resize_object_add(ad->win, ad->conformant);

	   // Show the conformant since all UI components are hidden by default
	   evas_object_show(ad->conformant);
	   // Create the naviframe
	   ad->naviframe = elm_naviframe_add(ad->conformant);
	   elm_object_content_set(ad->conformant, ad->naviframe);

	   // Show the box
	   evas_object_show(ad->conformant);
	   // Create the box
	   Evas_Object *box = elm_box_add(ad->naviframe);

	   // Set the box vertical
	   elm_box_horizontal_set(box, EINA_FALSE);

	   elm_box_padding_set(box,10,10);

	   // The box expands when its contents need more space
	   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	   // The box fills the available space
	   evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

	   // Add the box in the naviframe container
	   elm_naviframe_item_push(ad->naviframe, "Wifi Analyzer", NULL, NULL, box, NULL);

	   // Show the box
	   evas_object_show(box);
	   box1=elm_box_add(ad->naviframe);
	   elm_box_horizontal_set(box1, EINA_TRUE);
	      elm_box_padding_set(box1, 8, 8);
	      evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	      evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	      evas_object_show(box1);

	      box2 = elm_box_add(box);
	      elm_box_padding_set(box2, 6, 6);
	      evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	      evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	      evas_object_show(box2);

	      elm_box_pack_end(box, box1);
	         elm_box_pack_end(box, box2);
	   // Create the label
	   Evas_Object *label = elm_label_add(box1);
	   // The label expands when its contents need more space
	   evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	   // The box fills the available space on the horizontal axis and is
	   // centered on the vertical axis (placed at 0.5 vertically, that is, in the
	   // middle)
	   evas_object_size_hint_align_set(label, EVAS_HINT_FILL, EVAS_HINT_FILL);

	   // Set the text for the label and set formatting through the HTML tags:
	   // - "Hello World!" centered on the first line
	   // - skip a line
	   // - Add a longer text that does not fit on a single line but wraps at
	   //   the word boundaries
	   elm_object_text_set(label,
	         "<align=left><font_size=55><color=#000000>IITH Guest</color></font_size></align><br>"

	         	 );

	   // Add the label at the end of the box
	   elm_box_pack_end(box1, label);
	   elm_box_pack_end(box1, box2);



	   // Show the label
	   evas_object_show(label);
	   //Evas_Object *label1;
	   ad->label2 = elm_label_add(box2);
	   evas_object_size_hint_weight_set(ad->label2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	   // The box fills the available space on the horizontal axis and is
	   // centered on the vertical axis (placed at 0.5 vertically, that is, in the
	   // middle)
	   evas_object_size_hint_align_set(ad->label2, EVAS_HINT_FILL, EVAS_HINT_FILL);

	   elm_object_text_set(ad->label2,
			   "<align=left><font_size=55><color=#000000>Smart X</color></font_size></align><br>"
	   	         "<br>\n"
	   	         	 );
	   elm_box_pack_end(box2, ad->label2);
	   //elm_box_pack_end(box2, box);
	   evas_object_show(ad->label2);
	   // Create the button
	   Evas_Object *button = elm_button_add(box1);

	   // The box expands when its contents need more space
	   evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	   // The button fills the available space on the horizontal axis and is
	   // placed at the bottom of the vertical axis (1 is the end of the axis,
	   // the coordinates start at (0, 0) on the top-left corner
	   evas_object_size_hint_align_set(button, EVAS_HINT_FILL, 0);

	   //evas_object_size_hint_min_set(button, 128, 128);

	   // Set the text for the button
	   elm_object_text_set(button, "i");

	   // Add a callback on the button for the "clicked" event; implementation of
	   // the callback is below
	   evas_object_smart_callback_add(button, "clicked", create_popup, ad);


	   // Add the UI component at the end of the box; since the axis starts in the top left
	   // corner and the box is vertical, the end of the box is below the label
	   elm_box_pack_end(box1, button);
	   //elm_box_pack_end(box1, box2);
	   // Show the button
	   evas_object_show(button);
	   // Show window after the GUI is set up


	   evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

// My code





int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
