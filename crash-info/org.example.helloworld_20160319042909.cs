S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160222.0729
Build-Date: 2016.02.22 07:29:10

Crash Information
Process Name: helloworld
PID: 8898
Date: 2016-03-19 04:29:09+0900
Executable File Path: /opt/usr/apps/org.example.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb72c94c8, esi = 0x00000000
ebp = 0xbf9afee8, esp = 0xbf9afec0
eax = 0xb3770d8c, ebx = 0xb63682b8
ecx = 0x00000000, edx = 0x80013099
eip = 0xb376f76f

Memory Information
MemTotal:      123 KB
MemFree:        39 KB
Buffers:         5 KB
Cached:     150016 KB
VmPeak:     105880 KB
VmSize:     105880 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22996 KB
VmRSS:       22996 KB
VmData:      44168 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33336 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8898 TID = 8898
8898 8913 8922 8923 8947 

Maps Information
b2c42000 b2c4c000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c5f000 b2c80000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c85000 b2c86000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c87000 b2c8c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c8d000 b2c8e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c8f000 b2c91000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c92000 b2c9e000 r-xp /usr/lib/libdrm.so.2.4.0
b2c9f000 b2ca2000 r-xp /usr/lib/libdri2.so.0.0.0
b2ca3000 b2cad000 r-xp /usr/lib/libtbm.so.1.0.0
b2cae000 b2cc3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cc4000 b2cd6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34d8000 b34ea000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34f1000 b34f2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34f3000 b34f4000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34f5000 b34f8000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34f9000 b34fc000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3604000 b360a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b360b000 b374f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b375f000 b3761000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3762000 b3763000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3764000 b376d000 r-xp /usr/lib/libeventsystem.so.0.0.1
b376e000 b3770000 r-xp /opt/usr/apps/org.example.helloworld/bin/helloworld
b3771000 b37ab000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41ae000 b41b9000 r-xp /lib/libnss_files-2.20-2014.11.so
b41bb000 b41c6000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41c8000 b41df000 r-xp /lib/libnsl-2.20-2014.11.so
b41e3000 b41eb000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41ed000 b4211000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4212000 b4213000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4214000 b4217000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4218000 b421f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4220000 b422a000 r-xp /usr/lib/libsensord-share.so
b422b000 b4247000 r-xp /usr/lib/libsensor.so.1.2.0
b4249000 b4252000 r-xp /usr/lib/libappcore-common.so.1.1
b4255000 b4257000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b426c000 b426e000 r-xp /usr/lib/libXau.so.6.0.0
b426f000 b4291000 r-xp /usr/lib/libxcb.so.1.1.0
b4293000 b429c000 r-xp /lib/libcrypt-2.20-2014.11.so
b42c5000 b42c7000 r-xp /usr/lib/libiri.so
b42c8000 b42ee000 r-xp /lib/libexpat.so.1.5.2
b42f0000 b435b000 r-xp /usr/lib/libssl.so.1.0.0
b4361000 b436d000 r-xp /usr/lib/libethumb.so.1.13.0
b436e000 b4372000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4373000 b45c3000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b3e000 b5b4e000 r-xp /usr/lib/libXi.so.6.1.0
b5b4f000 b5b51000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b52000 b5b58000 r-xp /usr/lib/libXtst.so.6.1.0
b5b59000 b5b63000 r-xp /usr/lib/libXrender.so.1.3.0
b5b64000 b5b6d000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b6f000 b5b71000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b72000 b5b77000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b78000 b5b8a000 r-xp /usr/lib/libXext.so.6.4.0
b5b8b000 b5b8d000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b8e000 b5b90000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b92000 b5cd4000 r-xp /usr/lib/libX11.so.6.3.0
b5cd8000 b5ce2000 r-xp /usr/lib/libXcursor.so.1.0.2
b5ce3000 b5cf9000 r-xp /usr/lib/libudev.so.1.6.0
b5cfc000 b5d00000 r-xp /lib/libattr.so.1.1.0
b5d01000 b5d30000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d32000 b5d38000 r-xp /usr/lib/libffi.so.6.0.2
b5d39000 b5d5c000 r-xp /lib/libz.so.1.2.8
b5d5d000 b5d60000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d61000 b5ebd000 r-xp /usr/lib/libxml2.so.2.9.2
b5ec3000 b5faa000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fb7000 b5fba000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fbb000 b5fdd000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fde000 b5ff2000 r-xp /lib/libresolv-2.20-2014.11.so
b5ff7000 b601b000 r-xp /usr/lib/liblzma.so.5.0.3
b601c000 b601e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6020000 b602a000 r-xp /usr/lib/libembryo.so.1.13.0
b602b000 b6054000 r-xp /usr/lib/libpng12.so.0.50.0
b6055000 b609e000 r-xp /usr/lib/libjpeg.so.8.0.2
b60af000 b60b6000 r-xp /lib/librt-2.20-2014.11.so
b60b8000 b60d7000 r-xp /usr/lib/libector.so.1.13.0
b60da000 b6107000 r-xp /usr/lib/liblua-5.1.so
b6108000 b6198000 r-xp /usr/lib/libfreetype.so.6.11.3
b619c000 b61da000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61db000 b61f1000 r-xp /usr/lib/libfribidi.so.0.3.1
b61f2000 b624b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b624e000 b6299000 r-xp /lib/libm-2.20-2014.11.so
b629b000 b62ad000 r-xp /usr/lib/libeio.so.1.13.0
b62ae000 b62b1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62b2000 b62b8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62b9000 b62dc000 r-xp /usr/lib/libefreet.so.1.13.0
b62df000 b630a000 r-xp /usr/lib/libeldbus.so.1.13.0
b630b000 b633f000 r-xp /usr/lib/libecore_con.so.1.13.0
b6341000 b634a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b634b000 b6354000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6355000 b6368000 r-xp /usr/lib/libeo.so.1.13.0
b636a000 b637d000 r-xp /usr/lib/libecore_input.so.1.13.0
b637e000 b6385000 r-xp /usr/lib/libecore_file.so.1.13.0
b6386000 b63a9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63aa000 b63d6000 r-xp /usr/lib/libeet.so.1.13.0
b63df000 b644a000 r-xp /usr/lib/libeina.so.1.13.0
b644d000 b6464000 r-xp /usr/lib/libefl.so.1.13.0
b6466000 b65cd000 r-xp /usr/lib/libicuuc.so.51.1
b65db000 b67e7000 r-xp /usr/lib/libicui18n.so.51.1
b67ef000 b683e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6840000 b685a000 r-xp /lib/libgcc_s-4.9.so.1
b685c000 b6860000 r-xp /lib/libcap.so.2.21
b6861000 b68a7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68a8000 b68af000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68b1000 b6903000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6905000 b6a90000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a95000 b6b63000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b66000 b6b6a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b6b000 b6b7a000 r-xp /usr/lib/libvconf.so.0.2.45
b6b7b000 b6b7e000 r-xp /usr/lib/libvasum.so.0.3.1
b6b7f000 b6b82000 r-xp /usr/lib/libttrace.so.1.1
b6b84000 b6b88000 r-xp /usr/lib/libiniparser.so.0
b6b89000 b6bb9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bba000 b6bc3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bc4000 b6be9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bea000 b6bfa000 r-xp /usr/lib/libunwind.so.8.0.1
b6c04000 b6db2000 r-xp /lib/libc-2.20-2014.11.so
b6dba000 b6efd000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6eff000 b6f57000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f58000 b6f8c000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f8f000 b7063000 r-xp /usr/lib/libedje.so.1.13.0
b7066000 b7092000 r-xp /usr/lib/libecore.so.1.13.0
b70a3000 b72c9000 r-xp /usr/lib/libevas.so.1.13.0
b72f1000 b7309000 r-xp /lib/libpthread-2.20-2014.11.so
b730d000 b7687000 r-xp /usr/lib/libelementary.so.1.13.0
b76a7000 b76ab000 r-xp /usr/lib/libsmack.so.1.0.0
b76ac000 b76b5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76b6000 b76b9000 r-xp /usr/lib/libdlog.so.0.0.0
b76ba000 b76bf000 r-xp /usr/lib/libbundle.so.0.1.22
b76c0000 b76c3000 r-xp /lib/libdl-2.20-2014.11.so
b76c5000 b76ea000 r-xp /usr/lib/libaul.so.0.1.0
b76ed000 b76ef000 r-xp /usr/lib/libappsvc.so.0.1.0
b76f0000 b76f5000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76f6000 b76fd000 r-xp /usr/lib/libappcore-efl.so.1.1
b76ff000 b7704000 r-xp /usr/lib/libsys-assert.so
b7707000 b7708000 r-xp [vdso]
b7708000 b772a000 r-xp /lib/ld-2.20-2014.11.so
b772c000 b7734000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8898)
Call Stack Count: 21
 0: clicked_cb + 0x2f (0xb376f76f) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x176f
 1: (0xb712c116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb6363319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6360d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb712e9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb73df404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7012ed9) [/usr/lib/libedje.so.1] + 0x83ed9
 7: (0xb70199b1) [/usr/lib/libedje.so.1] + 0x8a9b1
 8: (0xb7013f7c) [/usr/lib/libedje.so.1] + 0x84f7c
 9: (0xb701446b) [/usr/lib/libedje.so.1] + 0x8546b
10: (0xb701462f) [/usr/lib/libedje.so.1] + 0x8562f
11: (0xb7079702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb7073055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb707c1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb707c587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb74d522d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb76f9dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb76f2c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: main + 0x279 (0xb376f029) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x1029
19: (0xb772e148) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0xb772e148
20: __libc_start_main + 0xde (0xb6c1be4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.helloworld
Package ID : org.example.helloworld
Version: 1.0.0
Package Type: tpk
App Name: helloworld
App ID: org.example.helloworld
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ocess 8861 is termianted
03-19 04:29:06.644+0900 D/STARTER ( 2925): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
03-19 04:29:06.644+0900 I/ESD     ( 3008): esd_main.c: __esd_app_dead_handler(1771) > pid: 8861
03-19 04:29:06.644+0900 W/AUL_AMD ( 2724): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8861
03-19 04:29:06.644+0900 W/AUL_AMD ( 2724): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8861
03-19 04:29:06.644+0900 D/AUL_AMD ( 2724): amd_key.c: _unregister_key_event(179) > ===key stack===
03-19 04:29:06.644+0900 E/AUL_AMD ( 2724): amd_launch.c: _revoke_temporary_permission(2128) > list or callee_label was null
03-19 04:29:06.644+0900 D/AUL_AMD ( 2724): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.helloworld)
03-19 04:29:06.644+0900 D/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 04:29:06.644+0900 E/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 04:29:06.654+0900 E/E17     ( 2854): e_border.c: e_border_show(2088) > BD_SHOW(0x01800002)
03-19 04:29:06.664+0900 E/RESOURCED( 2927): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.947
03-19 04:29:06.664+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2947
03-19 04:29:06.664+0900 D/RESOURCED( 2927): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2947, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
03-19 04:29:06.664+0900 D/RESOURCED( 2927): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2947, appname = org.tizen.homescreen
03-19 04:29:06.664+0900 D/RESOURCED( 2927): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2947
03-19 04:29:06.664+0900 D/RESOURCED( 2927): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8861
03-19 04:29:06.664+0900 D/RESOURCED( 2927): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.helloworld, pkgname = org.example.helloworld, ref = 0
03-19 04:29:06.684+0900 E/E17     ( 2854): e_border.c: e_border_hide(2248) > BD_HIDE(0x01a00002), visible:1
03-19 04:29:06.694+0900 D/INDICATOR( 2930): main.c: _property_changed_cb(432) > UNSNIFF API 1a00002
03-19 04:29:06.694+0900 D/INDICATOR( 2930): util.c: util_signal_emit_by_win(116) > emission bg.translucent
03-19 04:29:06.694+0900 D/INDICATOR( 2930): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-19 04:29:06.694+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 04:29:06.694+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 04:29:06.694+0900 D/INDICATOR( 2930): main.c: _rotate_window(252) > port :: hide more icon
03-19 04:29:06.724+0900 W/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2947
03-19 04:29:06.724+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 0
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-19 04:29:06.764+0900 I/APP_CORE( 2947): appcore-efl.c: __do_app(496) > [APP 2947] Event: RESUME State: PAUSED
03-19 04:29:06.764+0900 D/LAUNCH  ( 2947): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __do_app(607) > [APP 2947] RESUME
03-19 04:29:06.764+0900 I/CAPI_APPFW_APPLICATION( 2947): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-19 04:29:06.764+0900 E/cluster-home( 2947): homescreen.cpp: OnResume(66) >  app resume
03-19 04:29:06.764+0900 D/cluster-home( 2947): widget-data-provider.cpp: SetBoxVisibility(1543) >  
03-19 04:29:06.764+0900 D/cluster-home( 2947): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
03-19 04:29:06.764+0900 D/WIDGET_VIEWER( 2947): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
03-19 04:29:06.764+0900 D/cluster-home( 2947): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
03-19 04:29:06.764+0900 D/cluster-home( 2947): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
03-19 04:29:06.764+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
03-19 04:29:06.764+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppResume(910) >  END
03-19 04:29:06.764+0900 D/cluster-view( 2947): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
03-19 04:29:06.764+0900 D/cluster-view( 2947): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
03-19 04:29:06.764+0900 D/cluster-view( 2947): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
03-19 04:29:06.764+0900 D/cluster-view( 2947): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
03-19 04:29:06.764+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
03-19 04:29:06.764+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
03-19 04:29:06.764+0900 D/test-log( 2947): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
03-19 04:29:06.764+0900 D/test-log( 2947): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
03-19 04:29:06.764+0900 D/cluster-view( 2947): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
03-19 04:29:06.764+0900 D/cluster-home( 2947): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
03-19 04:29:06.764+0900 D/LAUNCH  ( 2947): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
03-19 04:29:06.764+0900 D/LAUNCH  ( 2947): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
03-19 04:29:06.764+0900 D/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 04:29:06.764+0900 E/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 04:29:06.764+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:29:06.774+0900 D/DATA_PROVIDER_MASTER( 2997): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2947 is resumed
03-19 04:29:06.774+0900 D/DATA_PROVIDER_MASTER( 2997): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-19 04:29:06.784+0900 E/DATA_PROVIDER_MASTER( 2997): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
03-19 04:29:06.784+0900 E/DATA_PROVIDER_MASTER( 2997): slave_life.c: slave_resume(1865) > [SECURE_LOG] Slave state[2]
03-19 04:29:06.804+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 15
03-19 04:29:06.804+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-19 04:29:06.804+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-19 04:29:06.804+0900 D/AUL_AMD ( 2724): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2947 is org.tizen.homescreen
03-19 04:29:06.804+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2947 : 0
03-19 04:29:06.804+0900 D/AUL     ( 3016): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
03-19 04:29:07.014+0900 D/cluster-view( 2947): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
03-19 04:29:07.014+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
03-19 04:29:07.014+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
03-19 04:29:07.014+0900 D/test-log( 2947): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
03-19 04:29:07.014+0900 D/test-log( 2947): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
03-19 04:29:07.014+0900 D/cluster-view( 2947): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
03-19 04:29:07.014+0900 D/cluster-home( 2947): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
03-19 04:29:07.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(588) > sleeping 1 sec...
03-19 04:29:07.124+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(52) > max_cmdline_size = 1053
03-19 04:29:07.124+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7cd6760
03-19 04:29:07.124+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(69) > get pre-initialization function
03-19 04:29:07.124+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(73) > get shutdown function
03-19 04:29:07.124+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7cd6a40
03-19 04:29:07.134+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7cd8640
03-19 04:29:07.134+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(69) > get pre-initialization function
03-19 04:29:07.134+0900 D/AUL_PAD ( 8898): preload.h: __preload_init(73) > get shutdown function
03-19 04:29:07.134+0900 D/AUL_PAD ( 8898): preexec.h: __preexec_init(76) > preexec start
03-19 04:29:07.134+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
03-19 04:29:07.134+0900 D/AUL     ( 8898): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
03-19 04:29:07.134+0900 D/AUL     ( 8898): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
03-19 04:29:07.134+0900 D/AUL     ( 8898): process_pool.c: __connect_to_launchpad(132) > send(8898) : 4
03-19 04:29:07.134+0900 D/AUL     ( 8898): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
03-19 04:29:07.134+0900 D/AUL_PAD ( 2996): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8898
03-19 04:29:07.264+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
03-19 04:29:07.274+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
03-19 04:29:07.274+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(693) > [candidate] ecore handler add
03-19 04:29:07.294+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: vconf_get_str(2887) > vconf_get_str(8747) : db/menu_widget/language error
03-19 04:29:07.504+0900 E/PKGMGR_INFO( 8747): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
03-19 04:29:07.504+0900 D/PKGMGR_INFO( 8747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:07.504+0900 D/PKGMGR_INFO( 8747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
03-19 04:29:07.504+0900 E/VCONF   ( 8747): vconf.c: vconf_get_str(2887) > vconf_get_str(8747) : db/menu_widget/language error
03-19 04:29:07.504+0900 E/PKGMGR_INFO( 8747): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
03-19 04:29:07.504+0900 D/PKGMGR_INFO( 8747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:07.504+0900 D/PKGMGR_INFO( 8747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: vconf_get_str(2887) > vconf_get_str(8747) : db/menu_widget/language error
03-19 04:29:07.514+0900 E/PKGMGR_INFO( 8747): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
03-19 04:29:07.514+0900 D/PKGMGR_INFO( 8747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:07.514+0900 D/PKGMGR_INFO( 8747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
03-19 04:29:07.514+0900 E/VCONF   ( 8747): vconf.c: vconf_get_str(2887) > vconf_get_str(8747) : db/menu_widget/language error
03-19 04:29:07.514+0900 E/PKGMGR_INFO( 8747): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
03-19 04:29:07.864+0900 E/EFL     ( 8872): eldbus<8872> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-8vxFynpXvi: Connection refused
03-19 04:29:07.864+0900 E/EFL     ( 8872): <8872> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
03-19 04:29:07.864+0900 E/EFL     ( 8872): elementary<8872> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
03-19 04:29:07.864+0900 D/APP_CORE( 8872): appcore.c: __aul_handler(587) > [APP 8872]     AUL event: AUL_START
03-19 04:29:07.864+0900 I/APP_CORE( 8872): appcore-efl.c: __do_app(496) > [APP 8872] Event: RESET State: CREATED
03-19 04:29:07.864+0900 D/APP_CORE( 8872): appcore-efl.c: __do_app(527) > [APP 8872] RESET
03-19 04:29:07.864+0900 D/LAUNCH  ( 8872): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
03-19 04:29:07.864+0900 D/APP_CORE( 8872): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
03-19 04:29:07.864+0900 D/APP_CORE( 8872): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:29:07.864+0900 E/SYSPOPUP( 8872): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
03-19 04:29:07.864+0900 E/SYSPOPUP( 8872): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
03-19 04:29:07.864+0900 E/SYSPOPUP( 8872): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
03-19 04:29:07.864+0900 D/LAUNCH  ( 8872): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
03-19 04:29:07.864+0900 D/APP_CORE( 8872): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
03-19 04:29:07.914+0900 D/AUL     ( 8872): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
03-19 04:29:07.914+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 22
03-19 04:29:07.914+0900 W/AUL_AMD ( 2724): amd_request.c: __request_handler(1056) > app status : 5
03-19 04:29:07.914+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(456) > pid(8872) status(5)
03-19 04:29:07.914+0900 D/APP_CORE( 8872): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
03-19 04:29:07.924+0900 E/EFL     ( 8872): eo<8872> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
03-19 04:29:07.924+0900 E/EFL     ( 8872): eo<8872> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
03-19 04:29:08.014+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
03-19 04:29:08.014+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
03-19 04:29:08.114+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
03-19 04:29:08.114+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
03-19 04:29:08.114+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
03-19 04:29:08.114+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
03-19 04:29:08.114+0900 D/test-log( 2947): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[195.00][263.00] to[195.00][263.00]!
03-19 04:29:08.114+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
03-19 04:29:08.114+0900 D/cluster-home( 2947): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
03-19 04:29:08.114+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x400075 
03-19 04:29:08.114+0900 D/cluster-home( 2947): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
03-19 04:29:08.114+0900 D/AUL     ( 2947): service.c: __set_bundle(186) > __set_bundle
03-19 04:29:08.114+0900 D/AUL     ( 2947): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
03-19 04:29:08.114+0900 D/AUL     ( 2947): service.c: __set_bundle(186) > __set_bundle
03-19 04:29:08.114+0900 D/AUL     ( 2947): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.helloworld - no result
03-19 04:29:08.114+0900 D/AUL     ( 2947): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.helloworld
03-19 04:29:08.114+0900 D/AUL     ( 2947): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 0
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.helloworld
03-19 04:29:08.124+0900 W/AUL_AMD ( 2724): amd_launch.c: _start_app(2230) > [SECURE_LOG] caller appid : org.tizen.homescreen
03-19 04:29:08.124+0900 W/AUL_AMD ( 2724): amd_launch.c: _start_app(2232) > caller pid : 2947
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2442) > win(800002) ecore_x_pointer_grab(1)
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_key.c: _key_grab(243) > _key_grab, win : 800002
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2447) > back key grab
03-19 04:29:08.124+0900 W/AUL_AMD ( 2724): amd_launch.c: __send_proc_prelaunch_signal(432) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.helloworld) pkgid(org.example.helloworld) attribute(600)
03-19 04:29:08.124+0900 D/RESOURCED( 2927): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.helloworld, pkgid = org.example.helloworld, flags = 1536
03-19 04:29:08.124+0900 D/RESOURCED( 2927): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.helloworld, pkgname = org.example.helloworld, ref = 1
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2516) > org.tizen.system.deviced.PmQos-AppLaunch : 0
03-19 04:29:08.124+0900 E/RESOURCED( 2927): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2646) > process_pool: false
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2649) > h/w acceleration: SYS
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2651) > [SECURE_LOG] appid: org.example.helloworld
03-19 04:29:08.124+0900 W/AUL_AMD ( 2724): amd_launch.c: _start_app(2663) > pad pid(-5)
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: __set_appinfo_for_launchpad(2947) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-19 04:29:08.124+0900 D/AUL_AMD ( 2724): amd_launch.c: __set_appinfo_for_launchpad(2950) > bundle_del error: -126
03-19 04:29:08.124+0900 D/AUL     ( 2724): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.helloworld
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
03-19 04:29:08.124+0900 W/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
03-19 04:29:08.124+0900 D/AUL     ( 2996): process_pool.c: __send_pkt_raw_data(219) > send(13) : 904 / 904
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8898, bin path: /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:29:08.124+0900 W/AUL_PAD ( 2996): launchpad.c: __send_result_to_caller(265) > Check app launching
03-19 04:29:08.124+0900 D/AUL_PAD ( 2996): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 904, pkt->len: 896
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.helloworld, launchpad type: 0
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.helloworld
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.helloworld
03-19 04:29:08.124+0900 D/AUL     ( 8898): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8913) is sent.
03-19 04:29:08.124+0900 D/AUL     ( 8898): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8913, signo: 10
03-19 04:29:08.124+0900 D/AUL     ( 8898): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.helloworld / pkg_type : rpm / app_path : /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.helloworld/bin/helloworld##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : PAAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFwAAAG9yZy5leGFtcGxlLmhlbGxvd29ybGQA##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NTgzMjkzNDgvMTI5Nzc5AA==##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTQ3AA==##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.helloworld/bin/helloworld, real app argc: 14
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
03-19 04:29:08.124+0900 D/AUL_PAD ( 8898): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.helloworld/bin/helloworld)
03-19 04:29:08.134+0900 I/CAPI_APPFW_APPLICATION( 8898): app_main.c: ui_app_main(788) > app_efl_main
03-19 04:29:08.134+0900 D/LAUNCH  ( 8898): appcore-efl.c: appcore_efl_main(1692) > [helloworld:Application:main:done]
03-19 04:29:08.134+0900 D/APP_CORE( 8898): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
03-19 04:29:08.134+0900 D/APP_CORE( 8898): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.helloworld/res/locale
03-19 04:29:08.134+0900 D/APP_CORE( 8898): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
03-19 04:29:08.144+0900 D/APP_CORE( 8898): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
03-19 04:29:08.144+0900 D/AUL     ( 8898): app_sock.c: __create_server_sock(156) > pg path - already exists
03-19 04:29:08.144+0900 D/APP_CORE( 8898): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4252520
03-19 04:29:08.144+0900 D/LAUNCH  ( 8898): appcore-efl.c: __before_loop(1136) > [helloworld:Platform:appcore_init:done]
03-19 04:29:08.144+0900 I/CAPI_APPFW_APPLICATION( 8898): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
03-19 04:29:08.194+0900 D/LAUNCH  ( 8898): appcore-efl.c: __before_loop(1154) > [helloworld:Application:create:done]
03-19 04:29:08.194+0900 E/E17     ( 2854): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01a00002)
03-19 04:29:08.194+0900 D/APP_CORE( 8898): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
03-19 04:29:08.204+0900 E/E17     ( 2854): e_border.c: e_border_show(2088) > BD_SHOW(0x01a00002)
03-19 04:29:08.214+0900 W/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8898
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore.c: __aul_handler(587) > [APP 8898]     AUL event: AUL_START
03-19 04:29:08.214+0900 I/APP_CORE( 8898): appcore-efl.c: __do_app(496) > [APP 8898] Event: RESET State: CREATED
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore-efl.c: __do_app(527) > [APP 8898] RESET
03-19 04:29:08.214+0900 D/LAUNCH  ( 8898): appcore-efl.c: __do_app(529) > [helloworld:Application:reset:start]
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:29:08.214+0900 I/CAPI_APPFW_APPLICATION( 8898): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
03-19 04:29:08.214+0900 D/LAUNCH  ( 8898): appcore-efl.c: __do_app(544) > [helloworld:Application:reset:done]
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
03-19 04:29:08.214+0900 E/EFL     ( 8898): edje<8898> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 04:29:08.214+0900 E/EFL     ( 8898): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:29:08.214+0900 E/EFL     ( 8898): edje<8898> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 04:29:08.214+0900 E/EFL     ( 8898): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:29:08.214+0900 E/EFL     ( 8898): edje<8898> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 04:29:08.214+0900 E/EFL     ( 8898): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:29:08.214+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:29:08.214+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:29:08.214+0900 D/INDICATOR( 2930): main.c: _property_changed_cb(432) > UNSNIFF API 1800002
03-19 04:29:08.214+0900 W/APP_CORE( 8898): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00002
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1a00002
03-19 04:29:08.214+0900 D/APP_CORE( 8898): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
03-19 04:29:08.214+0900 D/AUL     ( 8898): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
03-19 04:29:08.214+0900 D/INDICATOR( 2930): util.c: util_signal_emit_by_win(116) > emission bg.opaque
03-19 04:29:08.214+0900 D/INDICATOR( 2930): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-19 04:29:08.214+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 04:29:08.214+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 04:29:08.214+0900 D/INDICATOR( 2930): main.c: _rotate_window(252) > port :: hide more icon
03-19 04:29:08.224+0900 D/AUL_PAD ( 2996): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
03-19 04:29:08.224+0900 W/AUL     ( 2724): app_signal.c: aul_send_app_launch_request_signal(393) > send_app_launch_signal, pid: 8898, appid: org.example.helloworld
03-19 04:29:08.224+0900 D/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 04:29:08.224+0900 E/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 04:29:08.224+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2698) > add app group info
03-19 04:29:08.224+0900 E/AUL     ( 2724): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
03-19 04:29:08.224+0900 D/AUL_AMD ( 2724): amd_status.c: _status_add_app_info_list(427) > pid(8898) appid(org.example.helloworld) pkgid(org.example.helloworld) comp(uiapp)
03-19 04:29:08.224+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 34
03-19 04:29:08.224+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 15
03-19 04:29:08.224+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:08.224+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:29:08.234+0900 D/AUL_AMD ( 2724): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8898 is org.example.helloworld
03-19 04:29:08.234+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8898 : 0
03-19 04:29:08.234+0900 D/AUL     ( 2947): launch.c: app_request_to_launchpad(425) > launch request result : 8898
03-19 04:29:08.234+0900 E/cluster-home( 2947): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.helloworld]
03-19 04:29:08.234+0900 D/test-log( 2947): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
03-19 04:29:08.234+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.helloworld, 8898
03-19 04:29:08.234+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.helloworld with pkgname
03-19 04:29:08.234+0900 E/RESOURCED( 2927): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.helloworld
03-19 04:29:08.234+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(888) > available memory = 332
03-19 04:29:08.234+0900 D/AUL     ( 3016): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 31
03-19 04:29:08.334+0900 D/APP_CORE( 8898): appcore.c: __prt_ltime(236) > [APP 8898] first idle after reset: 214 msec
03-19 04:29:08.344+0900 E/E17     ( 2854): e_border.c: e_border_hide(2248) > BD_HIDE(0x01800002), visible:1
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(456) > pid(2947) status(4)
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(468) > pid(2947) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
03-19 04:29:08.354+0900 D/AUL     ( 2724): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
03-19 04:29:08.354+0900 W/AUL     ( 2724): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 2947, appid: org.tizen.homescreen, status: bg
03-19 04:29:08.354+0900 D/APP_CORE( 2947): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 1
03-19 04:29:08.354+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
03-19 04:29:08.354+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
03-19 04:29:08.354+0900 I/APP_CORE( 2947): appcore-efl.c: __do_app(496) > [APP 2947] Event: PAUSE State: RUNNING
03-19 04:29:08.354+0900 D/APP_CORE( 2947): appcore-efl.c: __do_app(565) > [APP 2947] PAUSE
03-19 04:29:08.354+0900 I/CAPI_APPFW_APPLICATION( 2947): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
03-19 04:29:08.354+0900 E/cluster-home( 2947): homescreen.cpp: OnPause(84) >  app pause
03-19 04:29:08.354+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
03-19 04:29:08.354+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppPause(923) >  END
03-19 04:29:08.354+0900 D/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 04:29:08.354+0900 E/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1a00002 fully_obscured 0
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-19 04:29:08.354+0900 I/APP_CORE( 8898): appcore-efl.c: __do_app(496) > [APP 8898] Event: RESUME State: CREATED
03-19 04:29:08.354+0900 D/LAUNCH  ( 8898): appcore-efl.c: __do_app(597) > [helloworld:Application:resume:start]
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __do_app(607) > [APP 8898] RESUME
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_launch.c: __e17_status_handler(2887) > pid(8898) status(3)
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_launch.c: __e17_status_handler(2893) > back key ungrab
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(456) > pid(8898) status(3)
03-19 04:29:08.354+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(468) > pid(8898) appid(org.example.helloworld) pkgid(org.example.helloworld) status(3)
03-19 04:29:08.354+0900 D/AUL     ( 2724): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.helloworld
03-19 04:29:08.354+0900 W/AUL     ( 2724): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 8898, appid: org.example.helloworld, status: fg
03-19 04:29:08.354+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8898
03-19 04:29:08.354+0900 D/RESOURCED( 2927): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8898, proc_name: org.example.helloworld, cg_name: foreground, oom_score_adj: 200
03-19 04:29:08.354+0900 D/RESOURCED( 2927): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8898
03-19 04:29:08.354+0900 I/APP_CORE( 8898): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
03-19 04:29:08.354+0900 I/APP_CORE( 8898): appcore-efl.c: __do_app(614) > [APP 8898] Initial Launching, call the resume_cb
03-19 04:29:08.354+0900 I/CAPI_APPFW_APPLICATION( 8898): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-19 04:29:08.354+0900 D/LAUNCH  ( 8898): appcore-efl.c: __do_app(636) > [helloworld:Application:resume:done]
03-19 04:29:08.354+0900 D/LAUNCH  ( 8898): appcore-efl.c: __do_app(638) > [helloworld:Application:Launching:done]
03-19 04:29:08.354+0900 D/APP_CORE( 8898): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 04:29:08.354+0900 E/APP_CORE( 8898): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 04:29:08.364+0900 D/DATA_PROVIDER_MASTER( 2997): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2947 is paused
03-19 04:29:08.364+0900 D/DATA_PROVIDER_MASTER( 2997): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-19 04:29:08.364+0900 E/DATA_PROVIDER_MASTER( 2997): slave_life.c: slave_pause(1897) > [SECURE_LOG] Slave state[2]
03-19 04:29:08.404+0900 D/RESOURCED( 2927): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8898, appname = org.example.helloworld, pkgname = org.example.helloworld
03-19 04:29:08.404+0900 D/RESOURCED( 2927): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8898, appname = org.example.helloworld
03-19 04:29:08.404+0900 D/RESOURCED( 2927): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8898
03-19 04:29:08.404+0900 I/RESOURCED( 2927): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
03-19 04:29:08.404+0900 I/RESOURCED( 2927): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
03-19 04:29:08.514+0900 D/AUL_AMD ( 2724): amd_launch.c: __e17_status_handler(2906) > pid(8898) status(0)
03-19 04:29:08.774+0900 E/RESOURCED( 2927): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
03-19 04:29:09.224+0900 D/AUL_PAD ( 2996): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
03-19 04:29:09.224+0900 D/AUL_PAD ( 8937): sigchild.h: __signal_unblock_sigchld(223) > SIGCHLD unblocked
03-19 04:29:09.244+0900 D/AUL_PAD ( 2996): sigchild.h: __send_app_launch_signal(130) > send launch signal done
03-19 04:29:09.494+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x402425 
03-19 04:29:09.584+0900 W/CRASH_MANAGER( 8747): worker.c: worker_job(1204) > 110889868656c145832934
