S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160222.0729
Build-Date: 2016.02.22 07:29:10

Crash Information
Process Name: helloworld
PID: 4138
Date: 2016-03-19 06:10:18+0900
Executable File Path: /opt/usr/apps/org.example.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8001149b

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb73364c8, esi = 0x8001148b
ebp = 0xbfbe8358, esp = 0xbfbe8330
eax = 0xb37ddd5c, ebx = 0xb63d52b8
ecx = 0x8001148b, edx = 0x80013099
eip = 0xb37dc73f

Memory Information
MemTotal:      123 KB
MemFree:        36 KB
Buffers:         8 KB
Cached:     143936 KB
VmPeak:     106900 KB
VmSize:     106900 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23028 KB
VmRSS:       23028 KB
VmData:      45188 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33336 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4138 TID = 4138
4138 4142 4325 4326 4334 

Maps Information
b2caf000 b2cb9000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ccc000 b2ced000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cf2000 b2cf3000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cf4000 b2cf9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cfa000 b2cfb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2cfc000 b2cfe000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cff000 b2d0b000 r-xp /usr/lib/libdrm.so.2.4.0
b2d0c000 b2d0f000 r-xp /usr/lib/libdri2.so.0.0.0
b2d10000 b2d1a000 r-xp /usr/lib/libtbm.so.1.0.0
b2d1b000 b2d30000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d31000 b2d43000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3545000 b3557000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b355e000 b355f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3560000 b3561000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3562000 b3565000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3566000 b3569000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3671000 b3677000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3678000 b37bc000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37cc000 b37ce000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37cf000 b37d0000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37d1000 b37da000 r-xp /usr/lib/libeventsystem.so.0.0.1
b37db000 b37dd000 r-xp /opt/usr/apps/org.example.helloworld/bin/helloworld
b37de000 b3818000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b421b000 b4226000 r-xp /lib/libnss_files-2.20-2014.11.so
b4228000 b4233000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4235000 b424c000 r-xp /lib/libnsl-2.20-2014.11.so
b4250000 b4258000 r-xp /lib/libnss_compat-2.20-2014.11.so
b425a000 b427e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b427f000 b4280000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4281000 b4284000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4285000 b428c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b428d000 b4297000 r-xp /usr/lib/libsensord-share.so
b4298000 b42b4000 r-xp /usr/lib/libsensor.so.1.2.0
b42b6000 b42bf000 r-xp /usr/lib/libappcore-common.so.1.1
b42c2000 b42c4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d9000 b42db000 r-xp /usr/lib/libXau.so.6.0.0
b42dc000 b42fe000 r-xp /usr/lib/libxcb.so.1.1.0
b4300000 b4309000 r-xp /lib/libcrypt-2.20-2014.11.so
b4332000 b4334000 r-xp /usr/lib/libiri.so
b4335000 b435b000 r-xp /lib/libexpat.so.1.5.2
b435d000 b43c8000 r-xp /usr/lib/libssl.so.1.0.0
b43ce000 b43da000 r-xp /usr/lib/libethumb.so.1.13.0
b43db000 b43df000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43e0000 b4630000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bab000 b5bbb000 r-xp /usr/lib/libXi.so.6.1.0
b5bbc000 b5bbe000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bbf000 b5bc5000 r-xp /usr/lib/libXtst.so.6.1.0
b5bc6000 b5bd0000 r-xp /usr/lib/libXrender.so.1.3.0
b5bd1000 b5bda000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bdc000 b5bde000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bdf000 b5be4000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be5000 b5bf7000 r-xp /usr/lib/libXext.so.6.4.0
b5bf8000 b5bfa000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bfb000 b5bfd000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bff000 b5d41000 r-xp /usr/lib/libX11.so.6.3.0
b5d45000 b5d4f000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d50000 b5d66000 r-xp /usr/lib/libudev.so.1.6.0
b5d69000 b5d6d000 r-xp /lib/libattr.so.1.1.0
b5d6e000 b5d9d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d9f000 b5da5000 r-xp /usr/lib/libffi.so.6.0.2
b5da6000 b5dc9000 r-xp /lib/libz.so.1.2.8
b5dca000 b5dcd000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dce000 b5f2a000 r-xp /usr/lib/libxml2.so.2.9.2
b5f30000 b6017000 r-xp /usr/lib/libstdc++.so.6.0.20
b6024000 b6027000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6028000 b604a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b604b000 b605f000 r-xp /lib/libresolv-2.20-2014.11.so
b6064000 b6088000 r-xp /usr/lib/liblzma.so.5.0.3
b6089000 b608b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b608d000 b6097000 r-xp /usr/lib/libembryo.so.1.13.0
b6098000 b60c1000 r-xp /usr/lib/libpng12.so.0.50.0
b60c2000 b610b000 r-xp /usr/lib/libjpeg.so.8.0.2
b611c000 b6123000 r-xp /lib/librt-2.20-2014.11.so
b6125000 b6144000 r-xp /usr/lib/libector.so.1.13.0
b6147000 b6174000 r-xp /usr/lib/liblua-5.1.so
b6175000 b6205000 r-xp /usr/lib/libfreetype.so.6.11.3
b6209000 b6247000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6248000 b625e000 r-xp /usr/lib/libfribidi.so.0.3.1
b625f000 b62b8000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62bb000 b6306000 r-xp /lib/libm-2.20-2014.11.so
b6308000 b631a000 r-xp /usr/lib/libeio.so.1.13.0
b631b000 b631e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b631f000 b6325000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6326000 b6349000 r-xp /usr/lib/libefreet.so.1.13.0
b634c000 b6377000 r-xp /usr/lib/libeldbus.so.1.13.0
b6378000 b63ac000 r-xp /usr/lib/libecore_con.so.1.13.0
b63ae000 b63b7000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b8000 b63c1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63c2000 b63d5000 r-xp /usr/lib/libeo.so.1.13.0
b63d7000 b63ea000 r-xp /usr/lib/libecore_input.so.1.13.0
b63eb000 b63f2000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f3000 b6416000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6417000 b6443000 r-xp /usr/lib/libeet.so.1.13.0
b644c000 b64b7000 r-xp /usr/lib/libeina.so.1.13.0
b64ba000 b64d1000 r-xp /usr/lib/libefl.so.1.13.0
b64d3000 b663a000 r-xp /usr/lib/libicuuc.so.51.1
b6648000 b6854000 r-xp /usr/lib/libicui18n.so.51.1
b685c000 b68ab000 r-xp /usr/lib/libecore_x.so.1.13.0
b68ad000 b68c7000 r-xp /lib/libgcc_s-4.9.so.1
b68c9000 b68cd000 r-xp /lib/libcap.so.2.21
b68ce000 b6914000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6915000 b691c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b691e000 b6970000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6972000 b6afd000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b02000 b6bd0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd3000 b6bd7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd8000 b6be7000 r-xp /usr/lib/libvconf.so.0.2.45
b6be8000 b6beb000 r-xp /usr/lib/libvasum.so.0.3.1
b6bec000 b6bef000 r-xp /usr/lib/libttrace.so.1.1
b6bf1000 b6bf5000 r-xp /usr/lib/libiniparser.so.0
b6bf6000 b6c26000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c27000 b6c30000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c31000 b6c56000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c57000 b6c67000 r-xp /usr/lib/libunwind.so.8.0.1
b6c71000 b6e1f000 r-xp /lib/libc-2.20-2014.11.so
b6e27000 b6f6a000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f6c000 b6fc4000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc5000 b6ff9000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ffc000 b70d0000 r-xp /usr/lib/libedje.so.1.13.0
b70d3000 b70ff000 r-xp /usr/lib/libecore.so.1.13.0
b7110000 b7336000 r-xp /usr/lib/libevas.so.1.13.0
b735e000 b7376000 r-xp /lib/libpthread-2.20-2014.11.so
b737a000 b76f4000 r-xp /usr/lib/libelementary.so.1.13.0
b7714000 b7718000 r-xp /usr/lib/libsmack.so.1.0.0
b7719000 b7722000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7723000 b7726000 r-xp /usr/lib/libdlog.so.0.0.0
b7727000 b772c000 r-xp /usr/lib/libbundle.so.0.1.22
b772d000 b7730000 r-xp /lib/libdl-2.20-2014.11.so
b7732000 b7757000 r-xp /usr/lib/libaul.so.0.1.0
b775a000 b775c000 r-xp /usr/lib/libappsvc.so.0.1.0
b775d000 b7762000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7763000 b776a000 r-xp /usr/lib/libappcore-efl.so.1.1
b776c000 b7771000 r-xp /usr/lib/libsys-assert.so
b7774000 b7775000 r-xp [vdso]
b7775000 b7797000 r-xp /lib/ld-2.20-2014.11.so
b7799000 b77a1000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4138)
Call Stack Count: 21
 0: clicked_cb + 0x2f (0xb37dc73f) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x173f
 1: (0xb7199116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63d0319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63cdd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb719b9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb744c404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb707fed9) [/usr/lib/libedje.so.1] + 0x83ed9
 7: (0xb70869b1) [/usr/lib/libedje.so.1] + 0x8a9b1
 8: (0xb7080f7c) [/usr/lib/libedje.so.1] + 0x84f7c
 9: (0xb708146b) [/usr/lib/libedje.so.1] + 0x8546b
10: (0xb708162f) [/usr/lib/libedje.so.1] + 0x8562f
11: (0xb70e6702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70e0055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70e91b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70e9587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb754222d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7766dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb775fc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: main + 0x279 (0xb37dbff9) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0xff9
19: (0xb779b148) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0xb779b148
20: __libc_start_main + 0xde (0xb6c88e4e) [/lib/libc.so.6] + 0x17e4e
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
reate_cb:306] lockw(0xb7de1898), lock_pid(4128)
03-19 06:10:12.317+0900 D/STARTER ( 2940): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb7de1898), lock_pid(4128)
03-19 06:10:12.377+0900 D/AUL_PAD ( 3009): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
03-19 06:10:12.377+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(393) > send_app_launch_signal, pid: 4138, appid: org.example.helloworld
03-19 06:10:12.377+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 06:10:12.377+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 06:10:12.377+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2698) > add app group info
03-19 06:10:12.377+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
03-19 06:10:12.377+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(4138) appid(org.example.helloworld) pkgid(org.example.helloworld) comp(uiapp)
03-19 06:10:12.377+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.helloworld, 4138
03-19 06:10:12.377+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.helloworld with pkgname
03-19 06:10:12.377+0900 E/RESOURCED( 2942): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.helloworld
03-19 06:10:12.377+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(888) > available memory = 313
03-19 06:10:12.427+0900 D/LAUNCH  ( 4138): appcore-efl.c: __before_loop(1154) > [helloworld:Application:create:done]
03-19 06:10:12.427+0900 E/E17     ( 2902): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02200002)
03-19 06:10:12.427+0900 D/STARTER ( 2940): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb7de1898), lock_pid(4128)
03-19 06:10:12.427+0900 D/APP_CORE( 4138): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
03-19 06:10:12.427+0900 E/STARTER ( 2940): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
03-19 06:10:12.437+0900 E/E17     ( 2902): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
03-19 06:10:12.447+0900 D/STARTER ( 2940): lock_mgr.c: _lock_show_cb(321) > [_lock_show_cb:321] lockw(0xb7de1898), lock_pid(4128)
03-19 06:10:12.447+0900 D/STARTER ( 2940): window_mgr.c: window_mgr_set_prop(206) > [window_mgr_set_prop:206] Check PID(4138) window. (lock_app_pid : 4128)
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore.c: __aul_handler(587) > [APP 4138]     AUL event: AUL_START
03-19 06:10:12.457+0900 I/APP_CORE( 4138): appcore-efl.c: __do_app(496) > [APP 4138] Event: RESET State: CREATED
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore-efl.c: __do_app(527) > [APP 4138] RESET
03-19 06:10:12.457+0900 D/LAUNCH  ( 4138): appcore-efl.c: __do_app(529) > [helloworld:Application:reset:start]
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 06:10:12.457+0900 I/CAPI_APPFW_APPLICATION( 4138): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
03-19 06:10:12.457+0900 D/AUL     ( 4138): service.c: __set_bundle(186) > __set_bundle
03-19 06:10:12.457+0900 D/LAUNCH  ( 4138): appcore-efl.c: __do_app(544) > [helloworld:Application:reset:done]
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
03-19 06:10:12.457+0900 E/EFL     ( 4138): edje<4138> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 06:10:12.457+0900 E/EFL     ( 4138): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 06:10:12.457+0900 E/EFL     ( 4138): edje<4138> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 06:10:12.457+0900 E/EFL     ( 4138): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 06:10:12.457+0900 E/EFL     ( 4138): edje<4138> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 06:10:12.457+0900 E/EFL     ( 4138): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 06:10:12.457+0900 W/APP_CORE( 4138): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2200002
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2200002
03-19 06:10:12.457+0900 D/APP_CORE( 4138): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
03-19 06:10:12.457+0900 D/AUL     ( 4138): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
03-19 06:10:12.457+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
03-19 06:10:12.997+0900 E/PKGMGR_SERVER( 4266): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-19 06:10:12.997+0900 E/PKGMGR_SERVER( 4266): pkgmgr-server.c: main(2265) > package manager server terminated.
03-19 06:10:13.087+0900 D/APP_CORE( 4138): appcore.c: __prt_ltime(236) > [APP 4138] first idle after reset: 823 msec
03-19 06:10:13.237+0900 E/CAPI_NETWORK_WIFI( 2945): libnetwork.c: _wifi_check_feature_supported(1342) > http://tizen.org/feature/network.wifi feature is disabled
03-19 06:10:13.237+0900 E/INDICATOR( 2945): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
03-19 06:10:13.237+0900 E/INDICATOR( 2945): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
03-19 06:10:13.237+0900 E/INDICATOR( 2945): 
03-19 06:10:13.387+0900 D/AUL_AMD ( 2740): amd_launch.c: __grab_timeout_handler(1444) > pid(4138) ecore_x_pointer_ungrab
03-19 06:10:13.387+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
03-19 06:10:13.387+0900 D/AUL_PAD ( 4329): sigchild.h: __signal_unblock_sigchld(223) > SIGCHLD unblocked
03-19 06:10:13.397+0900 D/AUL_PAD ( 3009): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
03-19 06:10:13.407+0900 D/AUL_PAD ( 3009): sigchild.h: __send_app_launch_signal(130) > send launch signal done
03-19 06:10:13.807+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-19 06:10:13.807+0900 W/AUL_AMD ( 2740): amd_launch.c: __grab_timeout_handler(1446) > back key ungrab error
03-19 06:10:13.837+0900 E/E17     ( 2902): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
03-19 06:10:13.837+0900 D/APP_CORE( 4138): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 1
03-19 06:10:13.837+0900 D/APP_CORE( 4138): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active -1
03-19 06:10:13.837+0900 D/APP_CORE( 4138): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
03-19 06:10:13.837+0900 I/APP_CORE( 4138): appcore-efl.c: __do_app(496) > [APP 4138] Event: PAUSE State: CREATED
03-19 06:10:13.837+0900 D/APP_CORE( 4138): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 06:10:13.837+0900 E/APP_CORE( 4138): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 06:10:13.837+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2966) status(4)
03-19 06:10:13.837+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2966) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
03-19 06:10:13.837+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
03-19 06:10:13.837+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 2966, appid: org.tizen.homescreen, status: bg
03-19 06:10:13.837+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2906) > pid(4138) status(0)
03-19 06:10:13.877+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.helloworld /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 06:10:13.877+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
03-19 06:10:13.887+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
03-19 06:10:14.777+0900 D/AUL_PAD ( 4329): launchpad_loader.c: main(588) > sleeping 1 sec...
03-19 06:10:14.777+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(52) > max_cmdline_size = 1053
03-19 06:10:14.787+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8137760
03-19 06:10:14.787+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(69) > get pre-initialization function
03-19 06:10:14.787+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(73) > get shutdown function
03-19 06:10:14.787+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8137a40
03-19 06:10:14.797+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8139640
03-19 06:10:14.797+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(69) > get pre-initialization function
03-19 06:10:14.797+0900 D/AUL_PAD ( 4329): preload.h: __preload_init(73) > get shutdown function
03-19 06:10:14.797+0900 D/AUL_PAD ( 4329): preexec.h: __preexec_init(76) > preexec start
03-19 06:10:14.797+0900 D/AUL_PAD ( 4329): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
03-19 06:10:14.797+0900 D/AUL     ( 4329): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
03-19 06:10:14.797+0900 D/AUL     ( 4329): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
03-19 06:10:14.797+0900 D/AUL     ( 4329): process_pool.c: __connect_to_launchpad(132) > send(4329) : 4
03-19 06:10:14.797+0900 D/AUL     ( 4329): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
03-19 06:10:14.797+0900 D/AUL_PAD ( 3009): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4329
03-19 06:10:14.907+0900 D/STARTER ( 2940): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb7de1898), lock_pid(4128)
03-19 06:10:14.907+0900 E/STARTER ( 2940): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
03-19 06:10:14.937+0900 D/AUL_PAD ( 4329): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
03-19 06:10:14.947+0900 D/AUL_PAD ( 4329): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
03-19 06:10:14.947+0900 D/AUL_PAD ( 4329): launchpad_loader.c: main(693) > [candidate] ecore handler add
03-19 06:10:14.947+0900 D/AUL_PAD ( 4329): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
03-19 06:10:15.407+0900 D/STARTER ( 2940): lock_mgr.c: _on_lcd_changed_receive(398) > [_on_lcd_changed_receive:398] LCD signal is received
03-19 06:10:15.407+0900 W/STARTER ( 2940): lock_mgr.c: _on_lcd_changed_receive(404) > [_on_lcd_changed_receive:404] LCD on
03-19 06:10:15.407+0900 D/STARTER ( 2940): lock_mgr.c: _on_lcd_changed_receive(408) > [_on_lcd_changed_receive:408] delete alarm : id(-1)
03-19 06:10:15.407+0900 D/ALARM_MANAGER( 2940): alarm-lib.c: alarmmgr_enum_alarm_ids(1345) > [SECURE_LOG] Enter
03-19 06:10:15.407+0900 I/LOCKSCREEN( 4128): dbus.c: _dbus_message_recv_cb(98) > [_dbus_message_recv_cb:98:I] LCD on
03-19 06:10:15.407+0900 I/LOCKSCREEN( 4128): dbus.c: _lcd_on_cb(248) > [_lcd_on_cb:248:I] Dbus LCD on
03-19 06:10:15.417+0900 D/LOCKSCREEN( 4128): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1458335415) formatted(Sat, March 19)
03-19 06:10:15.417+0900 D/LOCKSCREEN( 4128): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1458335415) formatted(6:10)
03-19 06:10:15.417+0900 D/LOCKSCREEN( 4128): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1458335415) formatted(AM)
03-19 06:10:15.417+0900 D/INDICATOR( 2945): main.c: on_changed_receive(496) > LCD On handling
03-19 06:10:15.417+0900 D/INDICATOR( 2945): icon.c: icon_set_update_flag(633) > icon_set_update_flag[633]	 "SET UPDATE FLAG 1"
03-19 06:10:15.417+0900 E/EFL     ( 4128): eo<4128> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800142a2 is not pointing to a valid object. Maybe it has already been freed.
03-19 06:10:15.417+0900 E/EFL     ( 4128): eo<4128> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800142a2) is an invalid ref.
03-19 06:10:15.417+0900 E/EFL     ( 4128): <4128> lib/ecore/ecore_timer.c:432 _ecore_timer_del() safety check failed: timer == NULL
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 6:10 4 h"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 6:10"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 6&#x2236;10"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147103512 Time: <font_size=23>6&#x2236;10</font_size> <font_size=22>AM</font_size></font>
03-19 06:10:15.417+0900 D/INDICATOR( 2945): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 50"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
03-19 06:10:15.417+0900 E/INDICATOR( 2945): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
03-19 06:10:15.417+0900 E/INDICATOR( 2945): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
03-19 06:10:15.417+0900 E/INDICATOR( 2945): list.c: list_try_to_find_icon_to_show(269) > default
03-19 06:10:15.417+0900 E/INDICATOR( 2945): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
03-19 06:10:15.417+0900 E/INDICATOR( 2945): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
03-19 06:10:15.417+0900 D/INDICATOR( 2945): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
03-19 06:10:15.417+0900 D/INDICATOR( 2945): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.hide"
03-19 06:10:15.417+0900 E/INDICATOR( 2945): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-19 06:10:15.417+0900 E/INDICATOR( 2945): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-19 06:10:15.417+0900 E/INDICATOR( 2945): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-19 06:10:15.417+0900 E/INDICATOR( 2945): box.c: _update_icon(172) > (!list) -> _update_icon() return
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 06:10:15.417+0900 D/INDICATOR( 2945): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 06:10:15.417+0900 D/INDICATOR( 2945): icon.c: _hide_more_noti(779) > port :: hide more icon
03-19 06:10:15.417+0900 E/INDICATOR( 2945): rssi.c: wake_up_cb(162) > (!s_info.updated_while_lcd_off) -> wake_up_cb() return
03-19 06:10:15.417+0900 D/ALARM_MANAGER( 2940): alarm-lib.c: alarmmgr_enum_alarm_ids(1382) > [SECURE_LOG] alarm_manager_call_alarm_get_number_of_ids_sync() is called
03-19 06:10:15.417+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3042) > before getting actual pid[2940]
03-19 06:10:15.417+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3044) > after getting actual pid[2940]
03-19 06:10:15.417+0900 E/ALARM_MANAGER( 2835): alarm-manager.c: _get_zone_name(573) > zone name [/]
03-19 06:10:15.417+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: __check_privilege_by_cookie(1966) > uid : 200
03-19 06:10:15.417+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: __check_privilege_by_cookie(1982) > The process(2940) was authenticated successfully.
03-19 06:10:15.417+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 37
03-19 06:10:15.417+0900 E/AUL_AMD ( 2740): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
03-19 06:10:15.417+0900 E/AUL_AMD ( 2740): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
03-19 06:10:15.417+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2940 : 0
03-19 06:10:15.417+0900 D/AUL     ( 2835): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
03-19 06:10:15.417+0900 D/AUL     ( 2835): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
03-19 06:10:15.417+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: __zone_get_appid_bypid(387) > cmdline(/usr/bin/starter)
03-19 06:10:15.417+0900 D/PKGMGR_INFO( 2835): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
03-19 06:10:15.417+0900 D/PKGMGR_INFO( 2835): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
03-19 06:10:15.427+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 37
03-19 06:10:15.427+0900 E/AUL_AMD ( 2740): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
03-19 06:10:15.427+0900 E/AUL_AMD ( 2740): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
03-19 06:10:15.427+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2940 : 0
03-19 06:10:15.427+0900 D/AUL     ( 2835): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
03-19 06:10:15.427+0900 D/AUL     ( 2835): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: __get_caller_unique_name(2015) > [SECURE_LOG] unique_name= /usr/bin/starter
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3065) > [SECURE_LOG] Called by process (pid:2940, unique_name:/usr/bin/starter)
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3073) > [SECURE_LOG] app_name=/usr/bin/starter, quark_app_unique_name=context-service
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3082) > [SECURE_LOG] number of alarms of the process (pid:2940, unique_name:/usr/bin/starter) is 0.
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2940): alarm-lib.c: alarmmgr_enum_alarm_ids(1401) > maxnum_of_ids[0]
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2940): alarm-lib.c: alarmmgr_enum_alarm_ids(1404) > [SECURE_LOG] alarm_manager_call_alarm_get_list_of_ids_sync() is called
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3104) > before getting actual pid[2940]
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3106) > after getting actual pid[2940]
03-19 06:10:15.427+0900 E/ALARM_MANAGER( 2835): alarm-manager.c: _get_zone_name(573) > zone name [/]
03-19 06:10:15.427+0900 E/ALARM_MANAGER( 2835): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3115) > [SECURE_LOG] called for pid(2940), but max_number_of_ids(0) is less than 0.
03-19 06:10:15.427+0900 D/ALARM_MANAGER( 2940): alarm-lib.c: alarmmgr_enum_alarm_ids(1435) > [SECURE_LOG] Leave
03-19 06:10:15.427+0900 D/eventsystem( 2441): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.display_state)
03-19 06:10:15.427+0900 D/eventsystem( 2441): eventsystem.c: __get_member_name_from_eventname(259) > member_name(display_state)
03-19 06:10:15.427+0900 D/eventsystem( 2441): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
03-19 06:10:15.427+0900 D/eventsystem( 2441): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
03-19 06:10:15.427+0900 D/eventsystem( 2441): eventsystem.c: __eventsystem_send_event(853) > member_name(display_state)
03-19 06:10:15.427+0900 D/DATA_PROVIDER_MASTER( 3010): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-19 06:10:15.437+0900 D/APP_CORE( 4138): appcore-rotation.c: __changed_cb(121) > [APP 4138] Rotation: 0 -> 1
03-19 06:10:15.437+0900 D/APP_CORE( 4138): appcore-rotation.c: __changed_cb(124) > [APP 4138] Rotation: 0 -> 1
03-19 06:10:15.437+0900 I/CAPI_APPFW_APPLICATION( 4138): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
03-19 06:10:15.437+0900 D/APP_CORE( 2966): appcore-rotation.c: __changed_cb(121) > [APP 2966] Rotation: 1 -> 1
03-19 06:10:15.447+0900 D/INDICATOR( 2945): main.c: _indicator_notify_pm_state_cb(169) > LCD is on
03-19 06:10:15.967+0900 D/LOCKSCREEN( 4128): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
03-19 06:10:15.967+0900 D/LOCKSCREEN( 4128): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(211), y(539)
03-19 06:10:15.967+0900 D/LOCKSCREEN( 4128): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
03-19 06:10:15.967+0900 D/LOCKSCREEN( 4128): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(371), y(695), w(85), h(85)
03-19 06:10:16.587+0900 D/LOCKSCREEN( 4128): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
03-19 06:10:16.587+0900 D/PROCESSMGR( 2902): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x20093c 
03-19 06:10:16.607+0900 I/LOCKSCREEN( 4128): lockscreen.c: _lcd_off_timer_cb(98) > [_lcd_off_timer_cb:98:I] lcd off : 10sec
03-19 06:10:16.607+0900 D/LOCKSCREEN( 4128): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1458335416) formatted(Sat, March 19)
03-19 06:10:16.607+0900 D/LOCKSCREEN( 4128): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1458335416) formatted(6:10)
03-19 06:10:16.607+0900 D/LOCKSCREEN( 4128): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1458335416) formatted(AM)
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/LOCKSCREEN( 4128): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
03-19 06:10:17.087+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: ui_app_exit(799) > ui_app_exit
03-19 06:10:17.087+0900 D/AUL     ( 4128): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
03-19 06:10:17.097+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 22
03-19 06:10:17.097+0900 W/AUL_AMD ( 2740): amd_request.c: __request_handler(1056) > app status : 5
03-19 06:10:17.097+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(4128) status(5)
03-19 06:10:17.097+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(4128) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
03-19 06:10:17.097+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
03-19 06:10:17.097+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 4128, appid: org.tizen.lockscreen, status: bg
03-19 06:10:17.097+0900 D/RESOURCED( 2942): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 4128, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
03-19 06:10:17.097+0900 D/RESOURCED( 2942): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 4128, appname = org.tizen.lockscreen
03-19 06:10:17.097+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 4128
03-19 06:10:17.097+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 3979 increase lru 2
03-19 06:10:17.097+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 3979 set score 330 (before 300)
03-19 06:10:17.097+0900 D/RESOURCED( 2942): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3979, proc_name: org.example.settingsui, cg_name: background, oom_score_adj: 330
03-19 06:10:17.097+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/background//cgroup.procs, value 3979
03-19 06:10:17.097+0900 D/APP_CORE( 4128): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
03-19 06:10:17.097+0900 I/CAPI_APPFW_APPLICATION( 4128): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
03-19 06:10:17.097+0900 D/LOCKSCREEN( 4128): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
03-19 06:10:17.097+0900 D/COM_CORE( 4128): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
03-19 06:10:17.097+0900 D/COM_CORE( 4128): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
03-19 06:10:17.097+0900 D/COM_CORE( 4128): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
03-19 06:10:17.097+0900 E/COM_CORE( 4128): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
03-19 06:10:17.097+0900 D/COM_CORE( 3010): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-19 06:10:17.097+0900 E/LOCKSCREEN( 4128): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
03-19 06:10:17.097+0900 E/LOCKSCREEN( 4128): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
03-19 06:10:17.097+0900 D/DATA_PROVIDER_MASTER( 3010): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb3300468 is terminated
03-19 06:10:17.097+0900 D/DATA_PROVIDER_MASTER( 3010): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-19 06:10:17.107+0900 D/LOCKSCREEN( 4128): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
03-19 06:10:17.107+0900 D/CALL_MGR_CLIENT( 4128): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
03-19 06:10:17.107+0900 D/CALL_MGR_CLIENT( 4128): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
03-19 06:10:17.107+0900 W/CALL_MGR_CLIENT( 4128): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
03-19 06:10:17.107+0900 D/CALL_MGR_CLIENT( 4128): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
03-19 06:10:17.107+0900 D/CALL_MGR_CLIENT( 4128): <LIB:cm_deinit:444> cm_deinit
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
03-19 06:10:17.107+0900 D/SYSTEM-SETTINGS( 4128): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
03-19 06:10:17.107+0900 D/SYSTEM-SETTINGS( 4128): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
03-19 06:10:17.107+0900 D/SYSTEM-SETTINGS( 4128): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
03-19 06:10:17.107+0900 D/LOCKSCREEN( 4128): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
03-19 06:10:17.107+0900 D/SYSTEM-SETTINGS( 4128): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
03-19 06:10:17.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4128): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
03-19 06:10:17.107+0900 D/SYSTEM-SETTINGS( 4128): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
03-19 06:10:17.107+0900 D/LOCKSCREEN( 4128): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
03-19 06:10:17.107+0900 E/E17_TZSH( 2902): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b392c5c0, role:118
03-19 06:10:17.117+0900 I/TZSH    ( 3011): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
03-19 06:10:17.117+0900 E/EFL     ( 4128): eo<4128> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
03-19 06:10:17.117+0900 E/EFL     ( 4128): eo<4128> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
03-19 06:10:17.117+0900 E/E17     ( 2902): e_border.c: e_border_hide(2248) > BD_HIDE(0x00e00007), visible:1
03-19 06:10:17.117+0900 E/EFL     ( 2902): eo<2902> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 06:10:17.117+0900 W/PROCESSMGR( 2902): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4138
03-19 06:10:17.117+0900 D/PROCESSMGR( 2902): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
03-19 06:10:17.117+0900 D/INDICATOR( 2945): main.c: _property_changed_cb(432) > UNSNIFF API e00007
03-19 06:10:17.117+0900 D/INDICATOR( 2945): util.c: util_signal_emit_by_win(116) > emission bg.opaque
03-19 06:10:17.117+0900 D/INDICATOR( 2945): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-19 06:10:17.117+0900 D/INDICATOR( 2945): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 06:10:17.117+0900 D/INDICATOR( 2945): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 06:10:17.117+0900 D/INDICATOR( 2945): main.c: _rotate_window(252) > port :: hide more icon
03-19 06:10:17.137+0900 E/EFL     ( 2902): eo<2902> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
03-19 06:10:17.147+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 06:10:17.147+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 4138 is org.example.helloworld
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 4138 : 0
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 0
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-19 06:10:17.147+0900 I/APP_CORE( 4138): appcore-efl.c: __do_app(496) > [APP 4138] Event: RESUME State: CREATED
03-19 06:10:17.147+0900 D/LAUNCH  ( 4138): appcore-efl.c: __do_app(597) > [helloworld:Application:resume:start]
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __do_app(607) > [APP 4138] RESUME
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2887) > pid(4138) status(3)
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
03-19 06:10:17.147+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-19 06:10:17.147+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > back key ungrab error
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(4138) status(3)
03-19 06:10:17.147+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(4138) appid(org.example.helloworld) pkgid(org.example.helloworld) status(3)
03-19 06:10:17.147+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.helloworld
03-19 06:10:17.147+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 4138, appid: org.example.helloworld, status: fg
03-19 06:10:17.147+0900 D/AUL     ( 3025): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 31
03-19 06:10:17.147+0900 I/APP_CORE( 4138): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
03-19 06:10:17.147+0900 I/APP_CORE( 4138): appcore-efl.c: __do_app(614) > [APP 4138] Initial Launching, call the resume_cb
03-19 06:10:17.147+0900 I/CAPI_APPFW_APPLICATION( 4138): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-19 06:10:17.147+0900 D/LAUNCH  ( 4138): appcore-efl.c: __do_app(636) > [helloworld:Application:resume:done]
03-19 06:10:17.147+0900 D/LAUNCH  ( 4138): appcore-efl.c: __do_app(638) > [helloworld:Application:Launching:done]
03-19 06:10:17.147+0900 D/APP_CORE( 4138): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 06:10:17.147+0900 E/APP_CORE( 4138): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 06:10:17.157+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 3908 increase lru 4
03-19 06:10:17.157+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 3908 set score 390 (before 360)
03-19 06:10:17.157+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2955 increase lru 10
03-19 06:10:17.157+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2955 set score 570 (before 540)
03-19 06:10:17.157+0900 D/RESOURCED( 2942): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
03-19 06:10:17.157+0900 D/RESOURCED( 2942): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4128, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
03-19 06:10:17.157+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 4128
03-19 06:10:17.197+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 4138
03-19 06:10:17.197+0900 D/RESOURCED( 2942): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4138, proc_name: org.example.helloworld, cg_name: foreground, oom_score_adj: 200
03-19 06:10:17.197+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 4138
03-19 06:10:17.257+0900 D/RESOURCED( 2942): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 4138, appname = org.example.helloworld, pkgname = org.example.helloworld
03-19 06:10:17.257+0900 D/RESOURCED( 2942): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 4138, appname = org.example.helloworld
03-19 06:10:17.257+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4138
03-19 06:10:17.257+0900 I/RESOURCED( 2942): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
03-19 06:10:17.257+0900 I/RESOURCED( 2942): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 06:10:17.347+0900 I/AUL_PAD ( 3009): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 4128 pgid = 4128
03-19 06:10:17.347+0900 I/AUL_PAD ( 3009): sigchild.h: __sigchild_action(141) > dead_pid(4128)
03-19 06:10:17.347+0900 D/AUL_PAD ( 3009): sigchild.h: __send_app_dead_signal(90) > send dead signal done
03-19 06:10:17.347+0900 I/AUL_PAD ( 3009): sigchild.h: __sigchild_action(147) > __send_app_dead_signal(0)
03-19 06:10:17.347+0900 I/AUL_PAD ( 3009): sigchild.h: __launchpad_process_sigchld(168) > after __sigchild_action
03-19 06:10:17.347+0900 E/AUL_PAD ( 3009): launchpad.c: main(688) > error reading sigchld info
03-19 06:10:17.357+0900 I/ESD     ( 3021): esd_main.c: __esd_app_dead_handler(1771) > pid: 4128
03-19 06:10:17.357+0900 W/AUL_AMD ( 2740): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 4128
03-19 06:10:17.357+0900 W/AUL_AMD ( 2740): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 4128
03-19 06:10:17.357+0900 D/AUL_AMD ( 2740): amd_key.c: _unregister_key_event(179) > ===key stack===
03-19 06:10:17.357+0900 E/AUL_AMD ( 2740): amd_launch.c: _revoke_temporary_permission(2128) > list or callee_label was null
03-19 06:10:17.357+0900 D/AUL_AMD ( 2740): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
03-19 06:10:17.357+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 06:10:17.357+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 06:10:17.357+0900 D/STARTER ( 2940): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 4128 is termianted
03-19 06:10:17.357+0900 D/STARTER ( 2940): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
03-19 06:10:17.357+0900 E/STARTER ( 2940): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
03-19 06:10:17.357+0900 D/STARTER ( 2940): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
03-19 06:10:17.357+0900 D/STARTER ( 2940): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
03-19 06:10:17.357+0900 D/INDICATOR( 2945): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
03-19 06:10:17.357+0900 D/RESOURCED( 2942): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 4128
03-19 06:10:17.357+0900 D/RESOURCED( 2942): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
03-19 06:10:17.367+0900 W/STARTER ( 2940): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0xe00007 is not transient
03-19 06:10:17.407+0900 D/VOLUME  ( 2955): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
03-19 06:10:18.117+0900 D/PROCESSMGR( 2902): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200962 
03-19 06:10:18.187+0900 W/CRASH_MANAGER( 4335): worker.c: worker_job(1204) > 110413868656c145833541
