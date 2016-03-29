S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160222.0729
Build-Date: 2016.02.22 07:29:10

Crash Information
Process Name: helloworld
PID: 5326
Date: 2016-03-19 07:31:42+0900
Executable File Path: /opt/usr/apps/org.example.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8001149b

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0xb73644c8, esi = 0x8001148b
ebp = 0xbff3bce8, esp = 0xbff3bcc0
eax = 0xb380bd84, ebx = 0xb64032b8
ecx = 0x8001148b, edx = 0x80013099
eip = 0xb380a76f

Memory Information
MemTotal:      123 KB
MemFree:        35 KB
Buffers:         8 KB
Cached:     144740 KB
VmPeak:     105864 KB
VmSize:     105864 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22980 KB
VmRSS:       22980 KB
VmData:      44152 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33336 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5326 TID = 5326
5326 5327 5513 5514 5519 

Maps Information
b2cdd000 b2ce7000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cfa000 b2d1b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d20000 b2d21000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d22000 b2d27000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d28000 b2d29000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d2a000 b2d2c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d2d000 b2d39000 r-xp /usr/lib/libdrm.so.2.4.0
b2d3a000 b2d3d000 r-xp /usr/lib/libdri2.so.0.0.0
b2d3e000 b2d48000 r-xp /usr/lib/libtbm.so.1.0.0
b2d49000 b2d5e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d5f000 b2d71000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3573000 b3585000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b358c000 b358d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b358e000 b358f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3590000 b3593000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3594000 b3597000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b369f000 b36a5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36a6000 b37ea000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37fa000 b37fc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37fd000 b37fe000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ff000 b3808000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3809000 b380b000 r-xp /opt/usr/apps/org.example.helloworld/bin/helloworld
b380c000 b3846000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4249000 b4254000 r-xp /lib/libnss_files-2.20-2014.11.so
b4256000 b4261000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4263000 b427a000 r-xp /lib/libnsl-2.20-2014.11.so
b427e000 b4286000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4288000 b42ac000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42ad000 b42ae000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42af000 b42b2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42b3000 b42ba000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42bb000 b42c5000 r-xp /usr/lib/libsensord-share.so
b42c6000 b42e2000 r-xp /usr/lib/libsensor.so.1.2.0
b42e4000 b42ed000 r-xp /usr/lib/libappcore-common.so.1.1
b42f0000 b42f2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4307000 b4309000 r-xp /usr/lib/libXau.so.6.0.0
b430a000 b432c000 r-xp /usr/lib/libxcb.so.1.1.0
b432e000 b4337000 r-xp /lib/libcrypt-2.20-2014.11.so
b4360000 b4362000 r-xp /usr/lib/libiri.so
b4363000 b4389000 r-xp /lib/libexpat.so.1.5.2
b438b000 b43f6000 r-xp /usr/lib/libssl.so.1.0.0
b43fc000 b4408000 r-xp /usr/lib/libethumb.so.1.13.0
b4409000 b440d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b440e000 b465e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd9000 b5be9000 r-xp /usr/lib/libXi.so.6.1.0
b5bea000 b5bec000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bed000 b5bf3000 r-xp /usr/lib/libXtst.so.6.1.0
b5bf4000 b5bfe000 r-xp /usr/lib/libXrender.so.1.3.0
b5bff000 b5c08000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c0d000 b5c12000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c13000 b5c25000 r-xp /usr/lib/libXext.so.6.4.0
b5c26000 b5c28000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c29000 b5c2b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c2d000 b5d6f000 r-xp /usr/lib/libX11.so.6.3.0
b5d73000 b5d7d000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d7e000 b5d94000 r-xp /usr/lib/libudev.so.1.6.0
b5d97000 b5d9b000 r-xp /lib/libattr.so.1.1.0
b5d9c000 b5dcb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dcd000 b5dd3000 r-xp /usr/lib/libffi.so.6.0.2
b5dd4000 b5df7000 r-xp /lib/libz.so.1.2.8
b5df8000 b5dfb000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dfc000 b5f58000 r-xp /usr/lib/libxml2.so.2.9.2
b5f5e000 b6045000 r-xp /usr/lib/libstdc++.so.6.0.20
b6052000 b6055000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6056000 b6078000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6079000 b608d000 r-xp /lib/libresolv-2.20-2014.11.so
b6092000 b60b6000 r-xp /usr/lib/liblzma.so.5.0.3
b60b7000 b60b9000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60bb000 b60c5000 r-xp /usr/lib/libembryo.so.1.13.0
b60c6000 b60ef000 r-xp /usr/lib/libpng12.so.0.50.0
b60f0000 b6139000 r-xp /usr/lib/libjpeg.so.8.0.2
b614a000 b6151000 r-xp /lib/librt-2.20-2014.11.so
b6153000 b6172000 r-xp /usr/lib/libector.so.1.13.0
b6175000 b61a2000 r-xp /usr/lib/liblua-5.1.so
b61a3000 b6233000 r-xp /usr/lib/libfreetype.so.6.11.3
b6237000 b6275000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6276000 b628c000 r-xp /usr/lib/libfribidi.so.0.3.1
b628d000 b62e6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62e9000 b6334000 r-xp /lib/libm-2.20-2014.11.so
b6336000 b6348000 r-xp /usr/lib/libeio.so.1.13.0
b6349000 b634c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b634d000 b6353000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6354000 b6377000 r-xp /usr/lib/libefreet.so.1.13.0
b637a000 b63a5000 r-xp /usr/lib/libeldbus.so.1.13.0
b63a6000 b63da000 r-xp /usr/lib/libecore_con.so.1.13.0
b63dc000 b63e5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63e6000 b63ef000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63f0000 b6403000 r-xp /usr/lib/libeo.so.1.13.0
b6405000 b6418000 r-xp /usr/lib/libecore_input.so.1.13.0
b6419000 b6420000 r-xp /usr/lib/libecore_file.so.1.13.0
b6421000 b6444000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6445000 b6471000 r-xp /usr/lib/libeet.so.1.13.0
b647a000 b64e5000 r-xp /usr/lib/libeina.so.1.13.0
b64e8000 b64ff000 r-xp /usr/lib/libefl.so.1.13.0
b6501000 b6668000 r-xp /usr/lib/libicuuc.so.51.1
b6676000 b6882000 r-xp /usr/lib/libicui18n.so.51.1
b688a000 b68d9000 r-xp /usr/lib/libecore_x.so.1.13.0
b68db000 b68f5000 r-xp /lib/libgcc_s-4.9.so.1
b68f7000 b68fb000 r-xp /lib/libcap.so.2.21
b68fc000 b6942000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6943000 b694a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b694c000 b699e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69a0000 b6b2b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b30000 b6bfe000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c01000 b6c05000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c06000 b6c15000 r-xp /usr/lib/libvconf.so.0.2.45
b6c16000 b6c19000 r-xp /usr/lib/libvasum.so.0.3.1
b6c1a000 b6c1d000 r-xp /usr/lib/libttrace.so.1.1
b6c1f000 b6c23000 r-xp /usr/lib/libiniparser.so.0
b6c24000 b6c54000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c55000 b6c5e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c5f000 b6c84000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c85000 b6c95000 r-xp /usr/lib/libunwind.so.8.0.1
b6c9f000 b6e4d000 r-xp /lib/libc-2.20-2014.11.so
b6e55000 b6f98000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f9a000 b6ff2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6ff3000 b7027000 r-xp /usr/lib/libsystemd.so.0.4.0
b702a000 b70fe000 r-xp /usr/lib/libedje.so.1.13.0
b7101000 b712d000 r-xp /usr/lib/libecore.so.1.13.0
b713e000 b7364000 r-xp /usr/lib/libevas.so.1.13.0
b738c000 b73a4000 r-xp /lib/libpthread-2.20-2014.11.so
b73a8000 b7722000 r-xp /usr/lib/libelementary.so.1.13.0
b7742000 b7746000 r-xp /usr/lib/libsmack.so.1.0.0
b7747000 b7750000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7751000 b7754000 r-xp /usr/lib/libdlog.so.0.0.0
b7755000 b775a000 r-xp /usr/lib/libbundle.so.0.1.22
b775b000 b775e000 r-xp /lib/libdl-2.20-2014.11.so
b7760000 b7785000 r-xp /usr/lib/libaul.so.0.1.0
b7788000 b778a000 r-xp /usr/lib/libappsvc.so.0.1.0
b778b000 b7790000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7791000 b7798000 r-xp /usr/lib/libappcore-efl.so.1.1
b779a000 b779f000 r-xp /usr/lib/libsys-assert.so
b77a2000 b77a3000 r-xp [vdso]
b77a3000 b77c5000 r-xp /lib/ld-2.20-2014.11.so
b77c7000 b77cf000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5326)
Call Stack Count: 21
 0: clicked_cb + 0x2f (0xb380a76f) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x176f
 1: (0xb71c7116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63fe319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63fbd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71c99e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb747a404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb70aded9) [/usr/lib/libedje.so.1] + 0x83ed9
 7: (0xb70b49b1) [/usr/lib/libedje.so.1] + 0x8a9b1
 8: (0xb70aef7c) [/usr/lib/libedje.so.1] + 0x84f7c
 9: (0xb70af46b) [/usr/lib/libedje.so.1] + 0x8546b
10: (0xb70af62f) [/usr/lib/libedje.so.1] + 0x8562f
11: (0xb7114702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb710e055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb71171b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb7117587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb757022d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7794dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb778dc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: main + 0x279 (0xb380a039) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0x1039
19: (0xb77c9148) [/opt/usr/apps/org.example.helloworld/bin/helloworld] + 0xb77c9148
20: __libc_start_main + 0xde (0xb6cb6e4e) [/lib/libc.so.6] + 0x17e4e
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
e successfully.
03-19 07:31:35.706+0900 D/rpm-installer( 5457): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.helloworld, 7), result=[0]
03-19 07:31:35.706+0900 D/rpm-installer( 5457): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5457), zone(host), pkg_typ(tpk), pkg_id(org.example.helloworld), key(install_percent), val(100)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5457), pkg_typ(tpk), pkg_id(org.example.helloworld), key(install_percent), val(100)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
03-19 07:31:35.706+0900 D/PKGMGR_INSTALLER( 5457): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.helloworld] key[install_percent] value[100]
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5457), zone(host), pkg_typ(tpk), pkg_id(org.example.helloworld), key(install_percent), val(100)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5457), pkg_typ(tpk), pkg_id(org.example.helloworld), key(install_percent), val(100)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
03-19 07:31:35.706+0900 D/rpm-installer( 5457): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.helloworld) is done.
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5457), zone(host), pkg_typ(tpk), pkg_id(org.example.helloworld), key(end), val(ok)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5457), pkg_typ(tpk), pkg_id(org.example.helloworld), key(end), val(ok)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
03-19 07:31:35.706+0900 D/PKGMGR_INSTALLER( 5457): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.helloworld] key[end] value[ok]
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(5457), zone(host), pkg_typ(tpk), pkg_id(org.example.helloworld), key(end), val(ok)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(5457), pkg_typ(tpk), pkg_id(org.example.helloworld), key(end), val(ok)
03-19 07:31:35.706+0900 D/PKGMGR  ( 5457): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
03-19 07:31:35.706+0900 D/PKGMGR  ( 3037): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.706+0900 D/PKGMGR  ( 3037): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
03-19 07:31:35.706+0900 D/PKGMGR  ( 3176): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.706+0900 D/PKGMGR  ( 3176): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.706+0900 D/PKGMGR  ( 3037): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.706+0900 D/PKGMGR  ( 3037): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
03-19 07:31:35.716+0900 D/PKGMGR  ( 2740): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.716+0900 D/AUL_AMD ( 2740): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.helloworld), key(end), value(ok)
03-19 07:31:35.716+0900 W/AUL_AMD ( 2740): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
03-19 07:31:35.726+0900 D/PKGMGR  ( 3011): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.726+0900 D/QUICKPANEL( 3011): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.helloworld key:install_percent val:100
03-19 07:31:35.726+0900 D/PKGMGR  ( 3011): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.726+0900 D/QUICKPANEL( 3011): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.helloworld key:end val:ok
03-19 07:31:35.726+0900 D/AUL_AMD ( 2740): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.helloworld, type:rpm
03-19 07:31:35.726+0900 D/PKGMGR  ( 3021): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.726+0900 D/ESD     ( 3021): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30210002), pkg_type(tpk), pkgid(org.example.helloworld), key(install_percent), val(100)
03-19 07:31:35.726+0900 D/PKGMGR  ( 3021): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.726+0900 D/ESD     ( 3021): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30210002), pkg_type(tpk), pkgid(org.example.helloworld), key(end), val(ok)
03-19 07:31:35.726+0900 D/ESD     ( 3021): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
03-19 07:31:35.726+0900 D/PKGMGR  ( 3025): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.726+0900 D/PKGMGR  ( 3025): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.746+0900 D/PKGMGR  ( 3010): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.helloworld] 100
03-19 07:31:35.746+0900 D/PKGMGR  ( 3010): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.helloworld] ok
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.helloworld], event_type[1]
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
03-19 07:31:35.746+0900 D/DATA_PROVIDER_MASTER( 3010): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.helloworld]
03-19 07:31:35.766+0900 D/PKGMGR  ( 5452): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.766+0900 D/PKGMGR  ( 5452): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.766+0900 D/PKGMGR  ( 3107): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.766+0900 D/PKGMGR  ( 3107): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.766+0900 D/ISF_PANEL_EFL( 3107): isf_panel_efl.cpp: _package_manager_event_cb(1289) > type=tpk package=org.example.helloworld event_type=UPDATE event_state=COMPLETED progress=100 error=0
03-19 07:31:35.776+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.776+0900 W/cluster-home( 2966): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.helloworld]
03-19 07:31:35.776+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[install_percent], value=[100]
03-19 07:31:35.776+0900 D/cluster-home( 2966): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29660003] pkg_type[tpk] package[org.example.helloworld] key[install_percent] val[100] pmsg[(null)]
03-19 07:31:35.776+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.776+0900 W/cluster-home( 2966): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.helloworld]
03-19 07:31:35.776+0900 D/cluster-home( 2966): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.helloworld]
03-19 07:31:35.776+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.helloworld_1329997354], pkg_type=[tpk], pkgid=[org.example.helloworld], key=[end], value=[ok]
03-19 07:31:35.776+0900 D/cluster-home( 2966): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29660003] pkg_type[tpk] package[org.example.helloworld] key[end] val[ok] pmsg[(null)]
03-19 07:31:35.776+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
03-19 07:31:35.776+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
03-19 07:31:35.776+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
03-19 07:31:35.786+0900 D/cluster-home( 2966): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
03-19 07:31:35.786+0900 D/cluster-home( 2966): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.helloworld]
03-19 07:31:35.786+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.helloworld]
03-19 07:31:35.786+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.helloworld]
03-19 07:31:35.786+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
03-19 07:31:35.786+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
03-19 07:31:35.786+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.helloworld]
03-19 07:31:35.796+0900 W/ISF_PANEL_EFL( 3107): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
03-19 07:31:35.796+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.helloworld] Name[helloworld] Icon[/opt/usr/apps/org.example.helloworld/shared/res/helloworld.png] enable[1] system[0]
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.helloworld]
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.helloworld
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.helloworld], name[helloworld], menuId[1], isPreload[0] isPreload[0]
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
03-19 07:31:35.796+0900 E/cluster-home( 2966): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.helloworld] Name[helloworld] Icon[/opt/usr/apps/org.example.helloworld/shared/res/helloworld.png] enable[1] system[0]
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [helloworld]
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
03-19 07:31:35.796+0900 D/test-log( 2966): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.helloworld/shared/res/helloworld.png], New icon path[/opt/usr/apps/org.example.helloworld/shared/res/helloworld.png]!!!!!
03-19 07:31:35.796+0900 D/cluster-home( 2966): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
03-19 07:31:35.936+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(5314)
03-19 07:31:35.936+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
03-19 07:31:35.976+0900 D/rpm-installer( 5457): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
03-19 07:31:35.976+0900 D/rpm-installer( 5457): rpm-appcore-intf.c: main(259) > ------------------------------------------------
03-19 07:31:35.976+0900 D/rpm-installer( 5457): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
03-19 07:31:35.976+0900 D/rpm-installer( 5457): rpm-appcore-intf.c: main(261) > ------------------------------------------------
03-19 07:31:35.996+0900 D/PKGMGR_SERVER( 5454): pkgmgr-server.c: sighandler(387) > child exit [5457]
03-19 07:31:35.996+0900 E/PKGMGR_SERVER( 5454): pkgmgr-server.c: sighandler(402) > child NORMAL exit [5457]
03-19 07:31:37.186+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(5124)
03-19 07:31:37.186+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
03-19 07:31:37.186+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(5124)
03-19 07:31:37.186+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.helloworld
03-19 07:31:37.446+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
03-19 07:31:37.446+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
03-19 07:31:37.446+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
03-19 07:31:37.446+0900 D/AUL     ( 2740): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5507, pid = 5509
03-19 07:31:37.446+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
03-19 07:31:37.446+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
03-19 07:31:37.446+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
03-19 07:31:37.446+0900 E/AUL_AMD ( 2740): amd_launch.c: _start_app(2223) > no caller appid info, ret: -1
03-19 07:31:37.446+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2232) > caller pid : 5509
03-19 07:31:37.446+0900 E/AUL_AMD ( 2740): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
03-19 07:31:37.446+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(432) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.helloworld) pkgid(org.example.helloworld) attribute(600)
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2646) > process_pool: false
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2649) > h/w acceleration: SYS
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > [SECURE_LOG] appid: org.example.helloworld
03-19 07:31:37.446+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2663) > pad pid(-5)
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2947) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-19 07:31:37.446+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2950) > bundle_del error: -126
03-19 07:31:37.446+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.helloworld
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
03-19 07:31:37.446+0900 W/AUL_PAD ( 3009): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
03-19 07:31:37.446+0900 D/AUL     ( 3009): process_pool.c: __send_pkt_raw_data(219) > send(13) : 636 / 636
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5326, bin path: /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 07:31:37.446+0900 W/AUL_PAD ( 3009): launchpad.c: __send_result_to_caller(265) > Check app launching
03-19 07:31:37.446+0900 D/AUL_PAD ( 3009): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
03-19 07:31:37.456+0900 D/RESOURCED( 2942): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.helloworld, pkgid = org.example.helloworld, flags = 1536
03-19 07:31:37.456+0900 D/RESOURCED( 2942): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.helloworld, pkgname = org.example.helloworld, ref = 1
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
03-19 07:31:37.456+0900 E/RESOURCED( 2942): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 636, pkt->len: 628
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.helloworld, launchpad type: 0
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.helloworld
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.helloworld
03-19 07:31:37.456+0900 D/AUL     ( 5326): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5327) is sent.
03-19 07:31:37.456+0900 D/AUL     ( 5326): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5327, signo: 10
03-19 07:31:37.456+0900 D/AUL     ( 5326): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.helloworld / pkg_type : rpm / app_path : /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.helloworld/bin/helloworld##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NTgzNDAyOTcvNDUyNTA3AA==##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1NTA5AA==##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.helloworld/bin/helloworld, real app argc: 8
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
03-19 07:31:37.456+0900 D/AUL_PAD ( 5326): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.helloworld/bin/helloworld)
03-19 07:31:37.456+0900 I/CAPI_APPFW_APPLICATION( 5326): app_main.c: ui_app_main(788) > app_efl_main
03-19 07:31:37.456+0900 D/LAUNCH  ( 5326): appcore-efl.c: appcore_efl_main(1692) > [helloworld:Application:main:done]
03-19 07:31:37.456+0900 D/APP_CORE( 5326): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
03-19 07:31:37.456+0900 D/APP_CORE( 5326): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.helloworld/res/locale
03-19 07:31:37.456+0900 D/APP_CORE( 5326): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
03-19 07:31:37.466+0900 D/APP_CORE( 5326): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
03-19 07:31:37.466+0900 D/AUL     ( 5326): app_sock.c: __create_server_sock(156) > pg path - already exists
03-19 07:31:37.466+0900 D/APP_CORE( 5326): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ed520
03-19 07:31:37.466+0900 D/LAUNCH  ( 5326): appcore-efl.c: __before_loop(1136) > [helloworld:Platform:appcore_init:done]
03-19 07:31:37.466+0900 I/CAPI_APPFW_APPLICATION( 5326): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
03-19 07:31:37.536+0900 D/LAUNCH  ( 5326): appcore-efl.c: __before_loop(1154) > [helloworld:Application:create:done]
03-19 07:31:37.536+0900 E/E17     ( 2902): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02200002)
03-19 07:31:37.536+0900 D/APP_CORE( 5326): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
03-19 07:31:37.536+0900 E/E17     ( 2902): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
03-19 07:31:37.546+0900 W/PROCESSMGR( 2902): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5326
03-19 07:31:37.546+0900 E/EFL     ( 2902): eo<2902> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 07:31:37.546+0900 E/EFL     ( 2902): eo<2902> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 07:31:37.546+0900 D/INDICATOR( 2945): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
03-19 07:31:37.546+0900 D/INDICATOR( 2945): util.c: util_signal_emit_by_win(116) > emission bg.opaque
03-19 07:31:37.546+0900 D/AUL_PAD ( 3009): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
03-19 07:31:37.546+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(393) > send_app_launch_signal, pid: 5326, appid: org.example.helloworld
03-19 07:31:37.546+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
03-19 07:31:37.546+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
03-19 07:31:37.546+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2698) > add app group info
03-19 07:31:37.546+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
03-19 07:31:37.546+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(5326) appid(org.example.helloworld) pkgid(org.example.helloworld) comp(uiapp)
03-19 07:31:37.556+0900 D/INDICATOR( 2945): main.c: _rotate_window(229) > Indicator angle is 0 degree
03-19 07:31:37.556+0900 D/INDICATOR( 2945): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
03-19 07:31:37.556+0900 D/INDICATOR( 2945): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
03-19 07:31:37.556+0900 D/INDICATOR( 2945): main.c: _rotate_window(252) > port :: hide more icon
03-19 07:31:37.556+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.helloworld, 5326
03-19 07:31:37.556+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.helloworld with pkgname
03-19 07:31:37.556+0900 E/RESOURCED( 2942): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.helloworld
03-19 07:31:37.556+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(888) > available memory = 322
03-19 07:31:37.566+0900 D/APP_CORE( 5326): appcore.c: __aul_handler(587) > [APP 5326]     AUL event: AUL_START
03-19 07:31:37.566+0900 I/APP_CORE( 5326): appcore-efl.c: __do_app(496) > [APP 5326] Event: RESET State: CREATED
03-19 07:31:37.566+0900 D/APP_CORE( 5326): appcore-efl.c: __do_app(527) > [APP 5326] RESET
03-19 07:31:37.566+0900 D/LAUNCH  ( 5326): appcore-efl.c: __do_app(529) > [helloworld:Application:reset:start]
03-19 07:31:37.566+0900 D/APP_CORE( 5326): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
03-19 07:31:37.566+0900 D/APP_CORE( 5326): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 07:31:37.566+0900 I/CAPI_APPFW_APPLICATION( 5326): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
03-19 07:31:37.566+0900 D/AUL     ( 5326): service.c: __set_bundle(186) > __set_bundle
03-19 07:31:37.566+0900 D/LAUNCH  ( 5326): appcore-efl.c: __do_app(544) > [helloworld:Application:reset:done]
03-19 07:31:37.566+0900 D/APP_CORE( 5326): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
03-19 07:31:37.566+0900 E/EFL     ( 5326): edje<5326> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 07:31:37.566+0900 E/EFL     ( 5326): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 07:31:37.566+0900 E/EFL     ( 5326): edje<5326> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 07:31:37.566+0900 E/EFL     ( 5326): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 07:31:37.566+0900 E/EFL     ( 5326): edje<5326> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
03-19 07:31:37.566+0900 E/EFL     ( 5326): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 07:31:37.576+0900 W/APP_CORE( 5326): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2200002
03-19 07:31:37.576+0900 D/APP_CORE( 5326): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2200002
03-19 07:31:37.576+0900 D/APP_CORE( 5326): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
03-19 07:31:37.576+0900 D/AUL     ( 5326): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
03-19 07:31:37.576+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
03-19 07:31:37.576+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
03-19 07:31:37.576+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 07:31:37.576+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
03-19 07:31:37.576+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5326 is org.example.helloworld
03-19 07:31:37.576+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5326 : 0
03-19 07:31:37.576+0900 D/AUL     ( 3025): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 31
03-19 07:31:37.686+0900 D/APP_CORE( 5326): appcore.c: __prt_ltime(236) > [APP 5326] first idle after reset: 244 msec
03-19 07:31:37.716+0900 E/E17     ( 2902): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
03-19 07:31:37.716+0900 D/APP_CORE( 5326): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 0
03-19 07:31:37.716+0900 D/APP_CORE( 5326): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
03-19 07:31:37.716+0900 D/APP_CORE( 5326): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
03-19 07:31:37.716+0900 I/APP_CORE( 5326): appcore-efl.c: __do_app(496) > [APP 5326] Event: RESUME State: CREATED
03-19 07:31:37.716+0900 D/LAUNCH  ( 5326): appcore-efl.c: __do_app(597) > [helloworld:Application:resume:start]
03-19 07:31:37.716+0900 D/APP_CORE( 5326): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
03-19 07:31:37.716+0900 D/APP_CORE( 5326): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
03-19 07:31:37.716+0900 D/APP_CORE( 5326): appcore-efl.c: __do_app(607) > [APP 5326] RESUME
03-19 07:31:37.726+0900 D/APP_CORE( 2966): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
03-19 07:31:37.726+0900 D/APP_CORE( 2966): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
03-19 07:31:37.726+0900 D/APP_CORE( 2966): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
03-19 07:31:37.726+0900 I/APP_CORE( 2966): appcore-efl.c: __do_app(496) > [APP 2966] Event: PAUSE State: RUNNING
03-19 07:31:37.726+0900 D/APP_CORE( 2966): appcore-efl.c: __do_app(565) > [APP 2966] PAUSE
03-19 07:31:37.726+0900 I/CAPI_APPFW_APPLICATION( 2966): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
03-19 07:31:37.726+0900 E/cluster-home( 2966): homescreen.cpp: OnPause(84) >  app pause
03-19 07:31:37.726+0900 D/cluster-view( 2966): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
03-19 07:31:37.726+0900 D/cluster-view( 2966): homescreen-view-manager.cpp: AppPause(923) >  END
03-19 07:31:37.726+0900 D/APP_CORE( 2966): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 07:31:37.726+0900 E/APP_CORE( 2966): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 07:31:37.736+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2966) status(4)
03-19 07:31:37.736+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2966) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
03-19 07:31:37.736+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
03-19 07:31:37.736+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 2966, appid: org.tizen.homescreen, status: bg
03-19 07:31:37.736+0900 I/APP_CORE( 5326): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
03-19 07:31:37.736+0900 I/APP_CORE( 5326): appcore-efl.c: __do_app(614) > [APP 5326] Initial Launching, call the resume_cb
03-19 07:31:37.736+0900 I/CAPI_APPFW_APPLICATION( 5326): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
03-19 07:31:37.736+0900 D/LAUNCH  ( 5326): appcore-efl.c: __do_app(636) > [helloworld:Application:resume:done]
03-19 07:31:37.736+0900 D/LAUNCH  ( 5326): appcore-efl.c: __do_app(638) > [helloworld:Application:Launching:done]
03-19 07:31:37.736+0900 D/APP_CORE( 5326): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
03-19 07:31:37.736+0900 E/APP_CORE( 5326): appcore-efl.c: __trm_app_info_send_socket(242) > access
03-19 07:31:37.736+0900 D/DATA_PROVIDER_MASTER( 3010): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2966 is paused
03-19 07:31:37.736+0900 D/DATA_PROVIDER_MASTER( 3010): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-19 07:31:37.736+0900 E/DATA_PROVIDER_MASTER( 3010): slave_life.c: slave_pause(1897) > [SECURE_LOG] Slave state[2]
03-19 07:31:37.746+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2887) > pid(5326) status(3)
03-19 07:31:37.746+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
03-19 07:31:37.746+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
03-19 07:31:37.746+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > back key ungrab error
03-19 07:31:37.746+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(5326) status(3)
03-19 07:31:37.746+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(5326) appid(org.example.helloworld) pkgid(org.example.helloworld) status(3)
03-19 07:31:37.746+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.helloworld
03-19 07:31:37.746+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(551) > send_app_status_change_signal, pid: 5326, appid: org.example.helloworld, status: fg
03-19 07:31:37.746+0900 D/RESOURCED( 2942): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5326
03-19 07:31:37.746+0900 D/RESOURCED( 2942): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5326, proc_name: org.example.helloworld, cg_name: foreground, oom_score_adj: 200
03-19 07:31:37.746+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5326
03-19 07:31:37.816+0900 D/RESOURCED( 2942): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5326, appname = org.example.helloworld, pkgname = org.example.helloworld
03-19 07:31:37.816+0900 D/RESOURCED( 2942): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5326, appname = org.example.helloworld
03-19 07:31:37.816+0900 D/RESOURCED( 2942): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5326
03-19 07:31:37.816+0900 I/RESOURCED( 2942): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
03-19 07:31:37.816+0900 I/RESOURCED( 2942): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
03-19 07:31:37.916+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2906) > pid(5326) status(0)
03-19 07:31:37.996+0900 E/PKGMGR_SERVER( 5454): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
03-19 07:31:37.996+0900 E/PKGMGR_SERVER( 5454): pkgmgr-server.c: main(2265) > package manager server terminated.
03-19 07:31:38.026+0900 E/CAPI_NETWORK_WIFI( 2945): libnetwork.c: _wifi_check_feature_supported(1342) > http://tizen.org/feature/network.wifi feature is disabled
03-19 07:31:38.026+0900 E/INDICATOR( 2945): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
03-19 07:31:38.026+0900 E/INDICATOR( 2945): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
03-19 07:31:38.026+0900 E/INDICATOR( 2945): 
03-19 07:31:38.556+0900 D/AUL_PAD ( 3009): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
03-19 07:31:38.556+0900 D/AUL_PAD ( 5517): sigchild.h: __signal_unblock_sigchld(223) > SIGCHLD unblocked
03-19 07:31:38.566+0900 D/AUL_PAD ( 3009): sigchild.h: __send_app_launch_signal(130) > send launch signal done
03-19 07:31:38.576+0900 E/RESOURCED( 2942): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.428
03-19 07:31:39.056+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.helloworld /opt/usr/apps/org.example.helloworld/bin/helloworld
03-19 07:31:39.056+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
03-19 07:31:39.066+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
03-19 07:31:39.606+0900 D/AUL_PAD ( 5517): launchpad_loader.c: main(588) > sleeping 1 sec...
03-19 07:31:39.606+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(52) > max_cmdline_size = 1053
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b94e3760
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(69) > get pre-initialization function
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(73) > get shutdown function
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b94e3a40
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b94e5640
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(69) > get pre-initialization function
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preload.h: __preload_init(73) > get shutdown function
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): preexec.h: __preexec_init(76) > preexec start
03-19 07:31:39.616+0900 D/AUL_PAD ( 5517): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
03-19 07:31:39.616+0900 D/AUL     ( 5517): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
03-19 07:31:39.616+0900 D/AUL     ( 5517): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
03-19 07:31:39.616+0900 D/AUL     ( 5517): process_pool.c: __connect_to_launchpad(132) > send(5517) : 4
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
03-19 07:31:39.616+0900 D/AUL_PAD ( 3009): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5517
03-19 07:31:39.616+0900 D/AUL     ( 5517): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
03-19 07:31:39.706+0900 D/AUL_PAD ( 5517): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
03-19 07:31:39.716+0900 D/AUL_PAD ( 5517): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
03-19 07:31:39.716+0900 D/AUL_PAD ( 5517): launchpad_loader.c: main(693) > [candidate] ecore handler add
03-19 07:31:39.716+0900 D/AUL_PAD ( 5517): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
03-19 07:31:42.636+0900 D/PROCESSMGR( 2902): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x201363 
03-19 07:31:42.656+0900 E/EFL     ( 5326): edje<5326> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
03-19 07:31:42.656+0900 E/EFL     ( 5326): By the power of Grayskull, your previous Embryo stack is now broken!
03-19 07:31:42.736+0900 D/APP_CORE( 2966): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
03-19 07:31:42.736+0900 I/APP_CORE( 2966): appcore-efl.c: __do_app(496) > [APP 2966] Event: MEM_FLUSH State: PAUSED
03-19 07:31:42.736+0900 D/APP_CORE( 2966): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
03-19 07:31:42.736+0900 D/APP_CORE( 2966): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2966
03-19 07:31:42.736+0900 D/APP_CORE( 2966): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
03-19 07:31:42.736+0900 D/RESOURCED( 2942): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2966
03-19 07:31:42.776+0900 E/EFL     ( 2902): eo<2902> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
03-19 07:31:42.776+0900 D/AUL_PAD ( 3009): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
03-19 07:31:42.776+0900 I/AUL_PAD ( 3009): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 5326 pgid = 5326
03-19 07:31:42.776+0900 I/AUL_PAD ( 3009): sigchild.h: __sigchild_action(141) > dead_pid(5326)
03-19 07:31:42.796+0900 W/CRASH_MANAGER( 5520): worker.c: worker_job(1204) > 110532668656c145834030
