S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160222.0729
Build-Date: 2016.02.22 07:29:10

Crash Information
Process Name: helloworld
PID: 8303
Date: 2016-03-19 04:22:58+0900
Executable File Path: /opt/usr/apps/org.example.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb73924c8, esi = 0x00000000
ebp = 0xbfd06228, esp = 0xbfd06200
eax = 0xb3839d8c, ebx = 0xb64312b8
ecx = 0x00000000, edx = 0x80013099
eip = 0xb383876f

Memory Information
MemTotal:      123 KB
MemFree:        40 KB
Buffers:         5 KB
Cached:     149188 KB
VmPeak:     105872 KB
VmSize:     105872 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22996 KB
VmRSS:       22996 KB
VmData:      44160 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33336 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8303 TID = 8303
8303 8304 8396 8397 8401 

Maps Information
b2d0b000 b2d15000 r-xp /usr/lib/libfeedback.so.0.1.4
b2d28000 b2d49000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d4e000 b2d4f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d50000 b2d55000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d56000 b2d57000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d58000 b2d5a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d5b000 b2d67000 r-xp /usr/lib/libdrm.so.2.4.0
b2d68000 b2d6b000 r-xp /usr/lib/libdri2.so.0.0.0
b2d6c000 b2d76000 r-xp /usr/lib/libtbm.so.1.0.0
b2d77000 b2d8c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d8d000 b2d9f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b35a1000 b35b3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b35ba000 b35bb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35bc000 b35bd000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35be000 b35c1000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c2000 b35c5000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36cd000 b36d3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d4000 b3818000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3828000 b382a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b382b000 b382c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b382d000 b3836000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3837000 b3839000 r-xp /opt/usr/apps/org.example.helloworld/bin/helloworld
b383a000 b3874000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4277000 b4282000 r-xp /lib/libnss_files-2.20-2014.11.so
b4284000 b428f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4291000 b42a8000 r-xp /lib/libnsl-2.20-2014.11.so
b42ac000 b42b4000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42b6000 b42da000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42db000 b42dc000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42dd000 b42e0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e1000 b42e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42e9000 b42f3000 r-xp /usr/lib/libsensord-share.so
b42f4000 b4310000 r-xp /usr/lib/libsensor.so.1.2.0
b4312000 b431b000 r-xp /usr/lib/libappcore-common.so.1.1
b431e000 b4320000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4335000 b4337000 r-xp /usr/lib/libXau.so.6.0.0
b4338000 b435a000 r-xp /usr/lib/libxcb.so.1.1.0
b435c000 b4365000 r-xp /lib/libcrypt-2.20-2014.11.so
b438e000 b4390000 r-xp /usr/lib/libiri.so
b4391000 b43b7000 r-xp /lib/libexpat.so.1.5.2
b43b9000 b4424000 r-xp /usr/lib/libssl.so.1.0.0
b442a000 b4436000 r-xp /usr/lib/libethumb.so.1.13.0
b4437000 b443b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b443c000 b468c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c07000 b5c17000 r-xp /usr/lib/libXi.so.6.1.0
b5c18000 b5c1a000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c1b000 b5c21000 r-xp /usr/lib/libXtst.so.6.1.0
b5c22000 b5c2c000 r-xp /usr/lib/libXrender.so.1.3.0
b5c2d000 b5c36000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c38000 b5c3a000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c3b000 b5c40000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c41000 b5c53000 r-xp /usr/lib/libXext.so.6.4.0
b5c54000 b5c56000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c57000 b5c59000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c5b000 b5d9d000 r-xp /usr/lib/libX11.so.6.3.0
b5da1000 b5dab000 r-xp /usr/lib/libXcursor.so.1.0.2
b5dac000 b5dc2000 r-xp /usr/lib/libudev.so.1.6.0
b5dc5000 b5dc9000 r-xp /lib/libattr.so.1.1.0
b5dca000 b5df9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dfb000 b5e01000 r-xp /usr/lib/libffi.so.6.0.2
b5e02000 b5e25000 r-xp /lib/libz.so.1.2.8
b5e26000 b5e29000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2a000 b5f86000 r-xp /usr/lib/libxml2.so.2.9.2
b5f8c000 b6073000 r-xp /usr/lib/libstdc++.so.6.0.20
b6080000 b6083000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6084000 b60a6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60a7000 b60bb000 r-xp /lib/libresolv-2.20-2014.11.so
b60c0000 b60e4000 r-xp /usr/lib/liblzma.so.5.0.3
b60e5000 b60e7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60e9000 b60f3000 r-xp /usr/lib/libembryo.so.1.13.0
b60f4000 b611d000 r-xp /usr/lib/libpng12.so.0.50.0
b611e000 b6167000 r-xp /usr/lib/libjpeg.so.8.0.2
b6178000 b617f000 r-xp /lib/librt-2.20-2014.11.so
b6181000 b61a0000 r-xp /usr/lib/libector.so.1.13.0
b61a3000 b61d0000 r-xp /usr/lib/liblua-5.1.so
b61d1000 b6261000 r-xp /usr/lib/libfreetype.so.6.11.3
b6265000 b62a3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a4000 b62ba000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bb000 b6314000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6317000 b6362000 r-xp /lib/libm-2.20-2014.11.so
b6364000 b6376000 r-xp /usr/lib/libeio.so.1.13.0
b6377000 b637a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637b000 b6381000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6382000 b63a5000 r-xp /usr/lib/libefreet.so.1.13.0
b63a8000 b63d3000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d4000 b6408000 r-xp /usr/lib/libecore_con.so.1.13.0
b640a000 b6413000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6414000 b641d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b641e000 b6431000 r-xp /usr/lib/libeo.so.1.13.0
b6433000 b6446000 r-xp /usr/lib/libecore_input.so.1.13.0
b6447000 b644e000 r-xp /usr/lib/libecore_file.so.1.13.0
b644f000 b6472000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6473000 b649f000 r-xp /usr/lib/libeet.so.1.13.0
b64a8000 b6513000 r-xp /usr/lib/libeina.so.1.13.0
b6516000 b652d000 r-xp /usr/lib/libefl.so.1.13.0
b652f000 b6696000 r-xp /usr/lib/libicuuc.so.51.1
b66a4000 b68b0000 r-xp /usr/lib/libicui18n.so.51.1
b68b8000 b6907000 r-xp /usr/lib/libecore_x.so.1.13.0
b6909000 b6923000 r-xp /lib/libgcc_s-4.9.so.1
b6925000 b6929000 r-xp /lib/libcap.so.2.21
b692a000 b6970000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6971000 b6978000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697a000 b69cc000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69ce000 b6b59000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b5e000 b6c2c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c2f000 b6c33000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c34000 b6c43000 r-xp /usr/lib/libvconf.so.0.2.45
b6c44000 b6c47000 r-xp /usr/lib/libvasum.so.0.3.1
b6c48000 b6c4b000 r-xp /usr/lib/libttrace.so.1.1
b6c4d000 b6c51000 r-xp /usr/lib/libiniparser.so.0
b6c52000 b6c82000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c83000 b6c8c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c8d000 b6cb2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb3000 b6cc3000 r-xp /usr/lib/libunwind.so.8.0.1
b6ccd000 b6e7b000 r-xp /lib/libc-2.20-2014.11.so
b6e83000 b6fc6000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fc8000 b7020000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7021000 b7055000 r-xp /usr/lib/libsystemd.so.0.4.0
b7058000 b712c000 r-xp /usr/lib/libedje.so.1.13.0
b712f000 b715b000 r-xp /usr/lib/libecore.so.1.13.0
b716c000 b7392000 r-xp /usr/lib/libevas.so.1.13.0
b73ba000 b73d2000 r-xp /lib/libpthread-2.20-2014.11.so
b73d6000 b7750000 r-xp /usr/lib/libelementary.so.1.13.0
b7770000 b7774000 r-xp /usr/lib/libsmack.so.1.0.0
b7775000 b777e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b777f000 b7782000 r-xp /usr/lib/libdlog.so.0.0.0
b7783000 b7788000 r-xp /usr/lib/libbundle.so.0.1.22
b7789000 b778c000 r-xp /lib/libdl-2.20-2014.11.so
b778e000 b77b3000 r-xp /usr/lib/libaul.so.0.1.0
b77b6000 b77b8000 r-xp /usr/lib/libappsvc.so.0.1.0
b77b9000 b77be000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77bf000 b77c6000 r-xp /usr/lib/libappcore-efl.so.1.1
b77c8000 b77cd000 r-xp /usr/lib/libsys-assert.so
b77d0000 b77d1000 r-xp [vdso]
b77d1000 b77f3000 r-xp /lib/ld-2.20-2014.11.so
b77f5000 b77fd000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8303)
Call Stack Count: 21
 0: clicked_cb + 0x2f (0xb383876f) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x176f
 1: (0xb71f5116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb642c319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6429d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71f79e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb74a8404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb70dbed9) [/usr/lib/libedje.so.1] + 0x83ed9
 7: (0xb70e29b1) [/usr/lib/libedje.so.1] + 0x8a9b1
 8: (0xb70dcf7c) [/usr/lib/libedje.so.1] + 0x84f7c
 9: (0xb70dd46b) [/usr/lib/libedje.so.1] + 0x8546b
10: (0xb70dd62f) [/usr/lib/libedje.so.1] + 0x8562f
11: (0xb7142702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb713c055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb71451b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb7145587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb759e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb77c2dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb77bbc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: main + 0x279 (0xb3838029) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x1029
19: (0xb77f7148) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0xb77f7148
20: __libc_start_main + 0xde (0xb6ce4e4e) [/lib/libc.so.6] + 0x17e4e
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
_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
03-19 04:22:54.609+0900 D/COM_CORE( 8248): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
03-19 04:22:54.609+0900 D/COM_CORE( 2997): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-19 04:22:54.609+0900 D/DATA_PROVIDER_MASTER( 2997): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb3214c00 is terminated
03-19 04:22:54.609+0900 D/DATA_PROVIDER_MASTER( 2997): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-19 04:22:54.609+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 0
03-19 04:22:54.609+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.helloworld
03-19 04:22:54.609+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.609+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.619+0900 I/AUL     ( 2724): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
03-19 04:22:54.619+0900 D/AUL     ( 2724): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8390, pid = 8392
03-19 04:22:54.619+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.619+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.619+0900 I/AUL     ( 2724): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
03-19 04:22:54.619+0900 E/AUL_AMD ( 2724): amd_launch.c: _start_app(2223) > no caller appid info, ret: -1
03-19 04:22:54.619+0900 W/AUL_AMD ( 2724): amd_launch.c: _start_app(2232) > caller pid : 8392
03-19 04:22:54.619+0900 E/AUL_AMD ( 2724): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
03-19 04:22:54.619+0900 W/AUL_AMD ( 2724): amd_launch.c: __send_proc_prelaunch_signal(432) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.helloworld) pkgid(org.example.helloworld) attribute(600)
03-19 04:22:54.619+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2646) > process_pool: false
03-19 04:22:54.619+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2649) > h/w acceleration: SYS
03-19 04:22:54.619+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2651) > [SECURE_LOG] appid: org.example.helloworld
03-19 04:22:54.619+0900 W/AUL_AMD ( 2724): amd_launch.c: _start_app(2663) > pad pid(-5)
03-19 04:22:54.619+0900 D/AUL_AMD ( 2724): amd_launch.c: __set_appinfo_for_launchpad(2947) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-19 04:22:54.619+0900 D/AUL_AMD ( 2724): amd_launch.c: __set_appinfo_for_launchpad(2950) > bundle_del error: -126
03-19 04:22:54.619+0900 D/AUL     ( 2724): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.helloworld
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
03-19 04:22:54.619+0900 W/AUL_PAD ( 2996): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
03-19 04:22:54.619+0900 D/AUL     ( 2996): process_pool.c: __send_pkt_raw_data(219) > send(13) : 636 / 636
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8303, bin path: /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:22:54.619+0900 W/AUL_PAD ( 2996): launchpad.c: __send_result_to_caller(265) > Check app launching
03-19 04:22:54.619+0900 D/AUL_PAD ( 2996): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 636, pkt->len: 628
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.helloworld, launchpad type: 0
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.helloworld
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.helloworld
03-19 04:22:54.619+0900 D/AUL     ( 8303): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8304) is sent.
03-19 04:22:54.619+0900 D/AUL     ( 8303): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8304, signo: 10
03-19 04:22:54.619+0900 D/AUL     ( 8303): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.helloworld / pkg_type : rpm / app_path : /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.helloworld/bin/helloworld##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NTgzMjg5NzQvNjE3MzUwAA==##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4MzkyAA==##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.helloworld/bin/helloworld, real app argc: 8
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
03-19 04:22:54.619+0900 D/AUL_PAD ( 8303): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.helloworld/bin/helloworld)
03-19 04:22:54.629+0900 I/CAPI_APPFW_APPLICATION( 8303): app_main.c: ui_app_main(788) > app_efl_main
03-19 04:22:54.629+0900 D/LAUNCH  ( 8303): appcore-efl.c: appcore_efl_main(1692) > [helloworld:Application:main:done]
03-19 04:22:54.629+0900 D/APP_CORE( 8303): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
03-19 04:22:54.629+0900 D/APP_CORE( 8303): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.helloworld/res/locale
03-19 04:22:54.629+0900 D/APP_CORE( 8303): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
03-19 04:22:54.639+0900 D/APP_CORE( 8303): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
03-19 04:22:54.639+0900 D/AUL     ( 8303): app_sock.c: __create_server_sock(156) > pg path - already exists
03-19 04:22:54.639+0900 D/APP_CORE( 8303): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb431b520
03-19 04:22:54.639+0900 D/LAUNCH  ( 8303): appcore-efl.c: __before_loop(1136) > [helloworld:Platform:appcore_init:done]
03-19 04:22:54.639+0900 I/CAPI_APPFW_APPLICATION( 8303): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
03-19 04:22:54.649+0900 E/COM_CORE( 8248): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
03-19 04:22:54.649+0900 E/LOCKSCREEN( 8248): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
03-19 04:22:54.649+0900 E/LOCKSCREEN( 8248): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
03-19 04:22:54.649+0900 D/RESOURCED( 2927): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.helloworld, pkgid = org.example.helloworld, flags = 1536
03-19 04:22:54.649+0900 D/STARTER ( 2925): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb80e28f0), lock_pid(8248)
03-19 04:22:54.649+0900 D/RESOURCED( 2927): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.helloworld, pkgname = org.example.helloworld, ref = 1
03-19 04:22:54.649+0900 E/RESOURCED( 2927): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-19 04:22:54.649+0900 D/LOCKSCREEN( 8248): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
03-19 04:22:54.649+0900 D/CALL_MGR_CLIENT( 8248): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
03-19 04:22:54.649+0900 D/CALL_MGR_CLIENT( 8248): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
03-19 04:22:54.649+0900 W/CALL_MGR_CLIENT( 8248): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
03-19 04:22:54.649+0900 D/CALL_MGR_CLIENT( 8248): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
03-19 04:22:54.649+0900 D/CALL_MGR_CLIENT( 8248): <LIB:cm_deinit:444> cm_deinit
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
03-19 04:22:54.649+0900 D/SYSTEM-SETTINGS( 8248): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
03-19 04:22:54.649+0900 D/SYSTEM-SETTINGS( 8248): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
03-19 04:22:54.649+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
03-19 04:22:54.649+0900 D/SYSTEM-SETTINGS( 8248): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
03-19 04:22:54.659+0900 D/STARTER ( 2925): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb80e28f0), lock_pid(8248)
03-19 04:22:54.659+0900 D/LOCKSCREEN( 8248): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
03-19 04:22:54.659+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 04:22:54.659+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
03-19 04:22:54.659+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
03-19 04:22:54.659+0900 D/SYSTEM-SETTINGS( 8248): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
03-19 04:22:54.659+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 04:22:54.659+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
03-19 04:22:54.659+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8248): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
03-19 04:22:54.659+0900 D/SYSTEM-SETTINGS( 8248): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
03-19 04:22:54.669+0900 D/LOCKSCREEN( 8248): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
03-19 04:22:54.669+0900 E/EFL     ( 8248): eo<8248> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
03-19 04:22:54.669+0900 E/EFL     ( 8248): eo<8248> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
03-19 04:22:54.669+0900 E/E17_TZSH( 2854): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b39385c0, role:118
03-19 04:22:54.669+0900 I/TZSH    ( 2998): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
03-19 04:22:54.669+0900 E/E17     ( 2854): e_border.c: e_border_hide(2248) > BD_HIDE(0x01a00007), visible:1
03-19 04:22:54.669+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:22:54.669+0900 W/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2947
03-19 04:22:54.669+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-19 04:22:54.669+0900 D/INDICATOR( 2930): main.c: _property_changed_cb(432) > UNSNIFF API 1a00007
03-19 04:22:54.669+0900 D/INDICATOR( 2930): util.c: util_signal_emit_by_win(116) > emission bg.translucent
03-19 04:22:54.669+0900 D/INDICATOR( 2930): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-19 04:22:54.669+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 04:22:54.669+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 04:22:54.669+0900 D/INDICATOR( 2930): main.c: _rotate_window(252) > port :: hide more icon
03-19 04:22:54.699+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 0
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-19 04:22:54.719+0900 I/APP_CORE( 2947): appcore-efl.c: __do_app(496) > [APP 2947] Event: RESUME State: PAUSED
03-19 04:22:54.719+0900 D/LAUNCH  ( 2947): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __do_app(607) > [APP 2947] RESUME
03-19 04:22:54.719+0900 I/CAPI_APPFW_APPLICATION( 2947): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-19 04:22:54.719+0900 E/cluster-home( 2947): homescreen.cpp: OnResume(66) >  app resume
03-19 04:22:54.719+0900 D/cluster-home( 2947): widget-data-provider.cpp: SetBoxVisibility(1543) >  
03-19 04:22:54.719+0900 D/cluster-home( 2947): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
03-19 04:22:54.719+0900 D/WIDGET_VIEWER( 2947): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
03-19 04:22:54.719+0900 D/cluster-home( 2947): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
03-19 04:22:54.719+0900 D/cluster-home( 2947): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
03-19 04:22:54.719+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
03-19 04:22:54.719+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppResume(910) >  END
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
03-19 04:22:54.719+0900 D/cluster-view( 2947): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
03-19 04:22:54.719+0900 D/AUL_PAD ( 2996): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
03-19 04:22:54.719+0900 D/cluster-view( 2947): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
03-19 04:22:54.719+0900 W/AUL     ( 2724): app_signal.c: aul_send_app_launch_request_signal(393) > send_app_launch_signal, pid: 8303, appid: org.example.helloworld
03-19 04:22:54.719+0900 D/test-log( 2947): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
03-19 04:22:54.719+0900 D/test-log( 2947): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
03-19 04:22:54.719+0900 D/cluster-home( 2947): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
03-19 04:22:54.719+0900 D/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 04:22:54.719+0900 E/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 04:22:54.719+0900 D/AUL_AMD ( 2724): amd_launch.c: _start_app(2698) > add app group info
03-19 04:22:54.719+0900 E/AUL     ( 2724): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
03-19 04:22:54.719+0900 D/LAUNCH  ( 2947): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
03-19 04:22:54.719+0900 D/LAUNCH  ( 2947): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
03-19 04:22:54.719+0900 D/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 04:22:54.719+0900 E/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 04:22:54.719+0900 D/AUL_AMD ( 2724): amd_status.c: _status_add_app_info_list(427) > pid(8303) appid(org.example.helloworld) pkgid(org.example.helloworld) comp(uiapp)
03-19 04:22:54.719+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 15
03-19 04:22:54.719+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.719+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.719+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.helloworld, 8303
03-19 04:22:54.719+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.helloworld with pkgname
03-19 04:22:54.719+0900 E/RESOURCED( 2927): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.helloworld
03-19 04:22:54.719+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(888) > available memory = 328
03-19 04:22:54.719+0900 D/cluster-view( 2947): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
03-19 04:22:54.719+0900 D/test-log( 2947): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
03-19 04:22:54.719+0900 D/test-log( 2947): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
03-19 04:22:54.719+0900 D/cluster-view( 2947): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
03-19 04:22:54.719+0900 D/cluster-home( 2947): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
03-19 04:22:54.719+0900 D/AUL_AMD ( 2724): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2947 is org.tizen.homescreen
03-19 04:22:54.719+0900 D/AUL     ( 3016): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
03-19 04:22:54.719+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2947 : 0
03-19 04:22:54.729+0900 D/DATA_PROVIDER_MASTER( 2997): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2947 is resumed
03-19 04:22:54.729+0900 D/DATA_PROVIDER_MASTER( 2997): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-19 04:22:54.729+0900 E/DATA_PROVIDER_MASTER( 2997): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
03-19 04:22:54.729+0900 E/DATA_PROVIDER_MASTER( 2997): slave_life.c: slave_resume(1865) > [SECURE_LOG] Slave state[2]
03-19 04:22:54.769+0900 D/LAUNCH  ( 8303): appcore-efl.c: __before_loop(1154) > [helloworld:Application:create:done]
03-19 04:22:54.769+0900 D/APP_CORE( 8303): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
03-19 04:22:54.779+0900 E/E17     ( 2854): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01000002)
03-19 04:22:54.779+0900 D/STARTER ( 2925): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb80e28f0), lock_pid(8248)
03-19 04:22:54.779+0900 E/STARTER ( 2925): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
03-19 04:22:54.789+0900 D/APP_CORE( 8303): appcore.c: __aul_handler(587) > [APP 8303]     AUL event: AUL_START
03-19 04:22:54.789+0900 I/APP_CORE( 8303): appcore-efl.c: __do_app(496) > [APP 8303] Event: RESET State: CREATED
03-19 04:22:54.789+0900 D/APP_CORE( 8303): appcore-efl.c: __do_app(527) > [APP 8303] RESET
03-19 04:22:54.789+0900 D/LAUNCH  ( 8303): appcore-efl.c: __do_app(529) > [helloworld:Application:reset:start]
03-19 04:22:54.789+0900 D/APP_CORE( 8303): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
03-19 04:22:54.789+0900 D/APP_CORE( 8303): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:22:54.789+0900 I/CAPI_APPFW_APPLICATION( 8303): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
03-19 04:22:54.789+0900 D/AUL     ( 8303): service.c: __set_bundle(186) > __set_bundle
03-19 04:22:54.789+0900 D/LAUNCH  ( 8303): appcore-efl.c: __do_app(544) > [helloworld:Application:reset:done]
03-19 04:22:54.789+0900 D/APP_CORE( 8303): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
03-19 04:22:54.789+0900 E/EFL     ( 8303): edje<8303> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 04:22:54.789+0900 E/EFL     ( 8303): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:22:54.789+0900 E/EFL     ( 8303): edje<8303> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 04:22:54.789+0900 E/EFL     ( 8303): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:22:54.789+0900 E/EFL     ( 8303): edje<8303> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 04:22:54.789+0900 E/EFL     ( 8303): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:22:54.799+0900 E/E17     ( 2854): e_border.c: e_border_show(2088) > BD_SHOW(0x01000002)
03-19 04:22:54.799+0900 D/STARTER ( 2925): lock_mgr.c: _lock_show_cb(321) > [_lock_show_cb:321] lockw(0xb80e28f0), lock_pid(8248)
03-19 04:22:54.799+0900 D/STARTER ( 2925): window_mgr.c: window_mgr_set_prop(206) > [window_mgr_set_prop:206] Check PID(8303) window. (lock_app_pid : 8248)
03-19 04:22:54.819+0900 W/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8303
03-19 04:22:54.819+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:22:54.819+0900 E/EFL     ( 2854): eo<2854> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 04:22:54.829+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 15
03-19 04:22:54.829+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.829+0900 D/PKGMGR_INFO( 2724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 04:22:54.829+0900 D/AUL_AMD ( 2724): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8303 is org.example.helloworld
03-19 04:22:54.829+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8303 : 0
03-19 04:22:54.829+0900 D/AUL     ( 3016): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 31
03-19 04:22:54.829+0900 D/INDICATOR( 2930): main.c: _property_changed_cb(432) > UNSNIFF API 1800002
03-19 04:22:54.829+0900 D/INDICATOR( 2930): util.c: util_signal_emit_by_win(116) > emission bg.opaque
03-19 04:22:54.829+0900 D/INDICATOR( 2930): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-19 04:22:54.829+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 04:22:54.829+0900 D/INDICATOR( 2930): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 04:22:54.829+0900 D/INDICATOR( 2930): main.c: _rotate_window(252) > port :: hide more icon
03-19 04:22:54.909+0900 D/APP_CORE( 8303): appcore.c: __prt_ltime(236) > [APP 8303] first idle after reset: 296 msec
03-19 04:22:54.909+0900 W/APP_CORE( 8303): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1000002
03-19 04:22:54.909+0900 D/APP_CORE( 8303): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1000002
03-19 04:22:54.909+0900 D/APP_CORE( 8303): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
03-19 04:22:54.909+0900 D/AUL     ( 8303): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
03-19 04:22:54.909+0900 D/AUL_AMD ( 2724): amd_request.c: __request_handler(838) > __request_handler: 34
03-19 04:22:54.959+0900 E/E17     ( 2854): e_border.c: e_border_hide(2248) > BD_HIDE(0x01800002), visible:1
03-19 04:22:54.959+0900 D/APP_CORE( 2947): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 1
03-19 04:22:54.959+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
03-19 04:22:54.959+0900 D/APP_CORE( 2947): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
03-19 04:22:54.959+0900 I/APP_CORE( 2947): appcore-efl.c: __do_app(496) > [APP 2947] Event: PAUSE State: RUNNING
03-19 04:22:54.959+0900 D/APP_CORE( 2947): appcore-efl.c: __do_app(565) > [APP 2947] PAUSE
03-19 04:22:54.959+0900 I/CAPI_APPFW_APPLICATION( 2947): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
03-19 04:22:54.959+0900 E/cluster-home( 2947): homescreen.cpp: OnPause(84) >  app pause
03-19 04:22:54.959+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
03-19 04:22:54.959+0900 D/cluster-view( 2947): homescreen-view-manager.cpp: AppPause(923) >  END
03-19 04:22:54.959+0900 D/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 04:22:54.959+0900 E/APP_CORE( 2947): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 04:22:54.959+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(456) > pid(2947) status(4)
03-19 04:22:54.959+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(468) > pid(2947) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
03-19 04:22:54.959+0900 D/AUL     ( 2724): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
03-19 04:22:54.959+0900 W/AUL     ( 2724): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 2947, appid: org.tizen.homescreen, status: bg
03-19 04:22:54.959+0900 D/AUL_AMD ( 2724): amd_launch.c: __e17_status_handler(2887) > pid(8303) status(3)
03-19 04:22:54.959+0900 D/AUL_AMD ( 2724): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
03-19 04:22:54.959+0900 W/AUL_AMD ( 2724): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-19 04:22:54.959+0900 W/AUL_AMD ( 2724): amd_launch.c: __e17_status_handler(2891) > back key ungrab error
03-19 04:22:54.959+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(456) > pid(8303) status(3)
03-19 04:22:54.959+0900 D/AUL_AMD ( 2724): amd_status.c: _status_update_app_info_list(468) > pid(8303) appid(org.example.helloworld) pkgid(org.example.helloworld) status(3)
03-19 04:22:54.959+0900 D/AUL     ( 2724): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.helloworld
03-19 04:22:54.959+0900 W/AUL     ( 2724): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 8303, appid: org.example.helloworld, status: fg
03-19 04:22:54.959+0900 D/RESOURCED( 2927): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8303
03-19 04:22:54.959+0900 D/RESOURCED( 2927): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8303, proc_name: org.example.helloworld, cg_name: foreground, oom_score_adj: 200
03-19 04:22:54.959+0900 D/RESOURCED( 2927): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8303
03-19 04:22:54.969+0900 D/DATA_PROVIDER_MASTER( 2997): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2947 is paused
03-19 04:22:54.969+0900 D/DATA_PROVIDER_MASTER( 2997): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-19 04:22:54.969+0900 E/DATA_PROVIDER_MASTER( 2997): slave_life.c: slave_pause(1897) > [SECURE_LOG] Slave state[2]
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1000002 fully_obscured 0
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-19 04:22:54.979+0900 I/APP_CORE( 8303): appcore-efl.c: __do_app(496) > [APP 8303] Event: RESUME State: CREATED
03-19 04:22:54.979+0900 D/LAUNCH  ( 8303): appcore-efl.c: __do_app(597) > [helloworld:Application:resume:start]
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __do_app(607) > [APP 8303] RESUME
03-19 04:22:54.979+0900 I/APP_CORE( 8303): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
03-19 04:22:54.979+0900 I/APP_CORE( 8303): appcore-efl.c: __do_app(614) > [APP 8303] Initial Launching, call the resume_cb
03-19 04:22:54.979+0900 I/CAPI_APPFW_APPLICATION( 8303): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-19 04:22:54.979+0900 D/LAUNCH  ( 8303): appcore-efl.c: __do_app(636) > [helloworld:Application:resume:done]
03-19 04:22:54.979+0900 D/LAUNCH  ( 8303): appcore-efl.c: __do_app(638) > [helloworld:Application:Launching:done]
03-19 04:22:54.979+0900 D/APP_CORE( 8303): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 04:22:54.979+0900 E/APP_CORE( 8303): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 04:22:54.999+0900 D/RESOURCED( 2927): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8303, appname = org.example.helloworld, pkgname = org.example.helloworld
03-19 04:22:54.999+0900 D/RESOURCED( 2927): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8303, appname = org.example.helloworld
03-19 04:22:54.999+0900 D/RESOURCED( 2927): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8303
03-19 04:22:54.999+0900 I/RESOURCED( 2927): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
03-19 04:22:54.999+0900 I/RESOURCED( 2927): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
03-19 04:22:54.999+0900 E/PKGMGR_SERVER( 8337): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-19 04:22:54.999+0900 E/PKGMGR_SERVER( 8337): pkgmgr-server.c: main(2265) > package manager server terminated.
03-19 04:22:55.149+0900 D/AUL_AMD ( 2724): amd_launch.c: __e17_status_handler(2906) > pid(8303) status(0)
03-19 04:22:55.259+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x401ebd 
03-19 04:22:55.719+0900 D/AUL_PAD ( 2996): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
03-19 04:22:55.719+0900 D/AUL_PAD ( 8399): sigchild.h: __signal_unblock_sigchld(223) > SIGCHLD unblocked
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): sigchild.h: __send_app_launch_signal(130) > send launch signal done
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 04:22:55.729+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 04:22:55.729+0900 I/AUL_PAD ( 2996): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 8248 pgid = 8248
03-19 04:22:55.729+0900 I/AUL_PAD ( 2996): sigchild.h: __sigchild_action(141) > dead_pid(8248)
03-19 04:22:55.739+0900 E/RESOURCED( 2927): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.850
03-19 04:22:55.739+0900 D/AUL_PAD ( 2996): sigchild.h: __send_app_dead_signal(90) > send dead signal done
03-19 04:22:55.739+0900 I/AUL_PAD ( 2996): sigchild.h: __sigchild_action(147) > __send_app_dead_signal(0)
03-19 04:22:55.739+0900 I/AUL_PAD ( 2996): sigchild.h: __launchpad_process_sigchld(168) > after __sigchild_action
03-19 04:22:55.739+0900 E/AUL_PAD ( 2996): launchpad.c: main(688) > error reading sigchld info
03-19 04:22:55.749+0900 I/ESD     ( 3008): esd_main.c: __esd_app_dead_handler(1771) > pid: 8248
03-19 04:22:55.749+0900 D/STARTER ( 2925): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 8248 is termianted
03-19 04:22:55.749+0900 D/STARTER ( 2925): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
03-19 04:22:55.749+0900 E/STARTER ( 2925): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
03-19 04:22:55.749+0900 D/STARTER ( 2925): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
03-19 04:22:55.749+0900 D/STARTER ( 2925): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
03-19 04:22:55.749+0900 W/STARTER ( 2925): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x1a00007 is not transient
03-19 04:22:55.749+0900 D/INDICATOR( 2930): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
03-19 04:22:55.749+0900 W/AUL_AMD ( 2724): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8248
03-19 04:22:55.749+0900 W/AUL_AMD ( 2724): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8248
03-19 04:22:55.749+0900 D/AUL_AMD ( 2724): amd_key.c: _unregister_key_event(179) > ===key stack===
03-19 04:22:55.749+0900 E/AUL_AMD ( 2724): amd_launch.c: _revoke_temporary_permission(2128) > list or callee_label was null
03-19 04:22:55.749+0900 D/AUL_AMD ( 2724): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
03-19 04:22:55.749+0900 D/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 04:22:55.749+0900 E/AUL     ( 2724): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 04:22:55.759+0900 E/RESOURCED( 2927): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.851
03-19 04:22:55.759+0900 D/RESOURCED( 2927): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8248
03-19 04:22:55.759+0900 D/RESOURCED( 2927): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
03-19 04:22:55.799+0900 D/VOLUME  ( 2938): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
03-19 04:22:56.219+0900 D/AUL_AMD ( 2724): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.helloworld /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 04:22:56.219+0900 D/RUA     ( 2724): rua.c: rua_add_history(179) > rua_add_history start
03-19 04:22:56.229+0900 D/RUA     ( 2724): rua.c: rua_add_history(247) > rua_add_history ok
03-19 04:22:56.269+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1000002
03-19 04:22:56.779+0900 D/AUL_PAD ( 8399): launchpad_loader.c: main(588) > sleeping 1 sec...
03-19 04:22:56.779+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(52) > max_cmdline_size = 1053
03-19 04:22:56.789+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9440760
03-19 04:22:56.789+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(69) > get pre-initialization function
03-19 04:22:56.789+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(73) > get shutdown function
03-19 04:22:56.789+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9440a40
03-19 04:22:56.799+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9442640
03-19 04:22:56.799+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(69) > get pre-initialization function
03-19 04:22:56.799+0900 D/AUL_PAD ( 8399): preload.h: __preload_init(73) > get shutdown function
03-19 04:22:56.799+0900 D/AUL_PAD ( 8399): preexec.h: __preexec_init(76) > preexec start
03-19 04:22:56.799+0900 D/AUL_PAD ( 8399): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
03-19 04:22:56.799+0900 D/AUL     ( 8399): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
03-19 04:22:56.799+0900 D/AUL     ( 8399): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
03-19 04:22:56.799+0900 D/AUL     ( 8399): process_pool.c: __connect_to_launchpad(132) > send(8399) : 4
03-19 04:22:56.799+0900 D/AUL     ( 8399): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
03-19 04:22:56.799+0900 D/AUL_PAD ( 2996): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8399
03-19 04:22:56.909+0900 D/AUL_PAD ( 8399): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
03-19 04:22:56.919+0900 D/AUL_PAD ( 8399): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
03-19 04:22:56.919+0900 D/AUL_PAD ( 8399): launchpad_loader.c: main(693) > [candidate] ecore handler add
03-19 04:22:56.919+0900 D/AUL_PAD ( 8399): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
03-19 04:22:58.609+0900 D/PROCESSMGR( 2854): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x401ebd 
03-19 04:22:58.619+0900 E/EFL     ( 8303): edje<8303> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
03-19 04:22:58.619+0900 E/EFL     ( 8303): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 04:22:58.749+0900 W/CRASH_MANAGER( 8402): worker.c: worker_job(1204) > 110830368656c145832897
