#Region INCLUDE
#include <AutoItConstants.au3>
#include<ImageSearch.au3>
#include <TreeViewConstants.au3>
#include <AVIConstants.au3>
#include <GuiConstantsEx.au3>
#include <TreeViewConstants.au3>
#EndRegion INCLUDE
Global $txtbxTendangnhap,$txtbxMatkhau
Func ClickOnImage($imagename)
	Local $x=0,$y=0

$search= _ImageSearch(@ScriptDir&'\SearchMaterials\'&$imagename,1,$x,$y,0)
if $search = 1 then
		MouseClick('left',$x,$y,1)
Else
		MsgBox(0,'not found','image not found',4)
EndIf

EndFunc

Func ClickNTimeMid($imagename,$n)

Local $x,$y
		$search= _ImageSearch(@ScriptDir&'\SearchMaterials\'&$imagename,1,$x,$y,0)
		if $search = 1 then
			MouseClick('left',$x,$y,$n)
			Sleep(500)

	EndIf
EndFunc

Func ClickNTimeTopLeft($imagename,$n)
Local $x=0,$y=0
$search= _ImageSearch(@ScriptDir&'\SearchMaterials\'&$imagename,0,$x,$y,0)
if $search = 1 then
		MouseClick('left',$x,$y,$n)
		Sleep(500)
EndIf
EndFunc


Func ClickNTimeNextTo($imagename,$n,$deltaX,$deltaY)

	Local $x,$y
		$search= _ImageSearch(@ScriptDir&'\SearchMaterials\'&$imagename,1,$x,$y,0)
		if $search = 1 then
		MouseClick('left',$x+$deltaX,$y+$deltaY,$n)
		Sleep(500)

	EndIf
	EndFunc

Func MoveMouse($imagename)

	Local $x,$y
		$search= _ImageSearch(@ScriptDir&'\SearchMaterials\'&$imagename,1,$x,$y,0)
		if $search = 1 then
			MouseMove($x,$y)


	EndIf
EndFunc


Func loopYoutubeVideo2()

	While 1
		Local $x=0,$y=0
		$youtubesearch=_ImageSearch(@ScriptDir&'\SearchMaterials\Youtube.bmp',1,$x,$y,0)
		If $youtubesearch=1 Then
			$a=$x+300
			$b=$y+300
			MouseMove($a,$b)
			Sleep(1000)
			MouseClick('right',$a,$b,1)
			MouseClick('left',$a+50,$b+30,1)
			ExitLoop
		EndIf
	WEnd

EndFunc

Func Prize()
;~ $url='https://www.youtube.com/watch?v=dyuBkX-BkN8'
$url='https://www.youtube.com/watch?v=38EyQ6Of10g'
ShellExecute($url)
loopYoutubeVideo2()
	EndFunc

Run('SilentEntityNugetData.exe')

Func UTCID_Login_05()
	ClickNTimeNextTo('TendangnhapLabel.bmp',2,50,0)
	Send('ST002')
	ClickNTimeNextTo('MatkhauLabel.bmp',2,50,0)
	Send('0')
	ClickNTimeTopLeft('Showpassword.bmp',1)

	ClickNTimeMid('Login.bmp',1)
	Sleep(1000)

	ClickNTimeMid('Exit.bmp',1)
	Sleep(1000)

	ClickNTimeNextTo('TendangnhapLabel.bmp',2,50,0)
	Send('{backspace}')
	ClickNTimeNextTo('MatkhauLabel.bmp',2,50,0)
	Send('{backspace}')


EndFunc

Func UTCID_Login_04()

	ClickNTimeNextTo('TendangnhapLabel.bmp',1,50,0)
	Send('1')
	ClickNTimeNextTo('MatkhauLabel.bmp',1,50,0)
	Send('0')

	ClickNTimeMid('Login.bmp',1)
	Sleep(1000)

	ClickNTimeMid('Exit.bmp',1)
	Sleep(1000)

	ClickNTimeNextTo('TendangnhapLabel.bmp',2,50,0)
	Send('{backspace}')
	ClickNTimeNextTo('MatkhauLabel.bmp',2,50,0)
	Send('{backspace}')

EndFunc

Func UTCID_Login_03()

	ClickNTimeNextTo('TendangnhapLabel.bmp',1,50,0)
	Send('0')
	ClickNTimeNextTo('MatkhauLabel.bmp',1,50,0)
	Send('0')

	ClickNTimeMid('Login.bmp',1)
	Sleep(1000)


	ClickNTimeMid('Exit.bmp',1)
	Sleep(1000)
	ClickNTimeNextTo('TendangnhapLabel.bmp',2,50,0)
	Send('{backspace}')
	ClickNTimeNextTo('MatkhauLabel.bmp',2,50,0)
	Send('{backspace}')


	EndFunc

Func UTCID_Login_01()
	ClickNTimeNextTo('TendangnhapLabel.bmp',1,50,0)
	Send('1')
	ClickNTimeNextTo('MatkhauLabel.bmp',1,50,0)
	Send('1')
	ClickNTimeTopLeft('Showpassword.bmp',1)
	ClickNTimeMid('Login.bmp',1)
	Sleep(300)

EndFunc

Func UTCID_Login_02()
	ClickNTimeNextTo('TendangnhapLabel.bmp',1,50,0)
	Send('ST002')
	ClickNTimeNextTo('MatkhauLabel.bmp',1,50,0)
	Send('1')
	ClickNTimeTopLeft('Showpassword.bmp',1)
	ClickNTimeMid('Login.bmp',1)
	Sleep(1000)

EndFunc

Func LoginForm($FormName)
			ClickNTimeMid($FormName,1)
	Sleep(1500)


	EndFunc


Func UNTCID_DeleteEmployee($ID)

	ClickNTimeNextTo($ID,1,714,0)
	Sleep(500)
	ClickNTimeMid('Yes.bmp',1)

	Sleep(500)
	ClickNTimeMid('OK.bmp',1)
	Sleep(500)

EndFunc

Func UNTCID_DeleteCustomer($ID)

	ClickNTimeNextTo($ID,1,700,0)
	Sleep(500)
	ClickNTimeMid('Yes.bmp',1)

	Sleep(500)
	ClickNTimeMid('OK.bmp',1)
	Sleep(500)

EndFunc

Func UNTCID_DeleteProduct($ID)

	ClickNTimeNextTo($ID,1,680,0)
	Sleep(500)
	ClickNTimeMid('Yes.bmp',1)

	Sleep(500)
	ClickNTimeMid('OK.bmp',1)
	Sleep(500)

EndFunc


Func UTCID_AddEmployee_01()

	ClickNTimeMid('txtbxHoVaTen.bmp',2)
	Send('nguyen van c')


	ClickNTimeMid('txtbxLuong.bmp',2)
	Send('840000')


	ClickNTimeMid('txtbxMaNhanVien.bmp',2)
	Send('ST005')


	ClickNTimeMid('txtbxCMND.bmp',2)
	Send('045216985315')


	ClickNTimeMid('txtbxMatKhau.bmp',2)
	Send('aejv7412')


	ClickNTimeMid('txtbxSoDienThoai.bmp',2)
	Send('0914568823')


	ClickNTimeMid('txtbxDiaChi.bmp',2)
	Send('123 Nguyen Dinh Chieu')


	ClickNTimeMid('txtbxEmail.bmp',2)
	Send('email@mail.com')


	ClickNTimeMid('btnOK.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_AddEmployee_02()

	ClickNTimeMid('txtbxHoVaTen.bmp',2)
	Send('nguyen van c')


	ClickNTimeMid('txtbxLuong.bmp',2)
	Send('840000')


	ClickNTimeMid('txtbxMaNhanVien.bmp',2)
	Send('ST002')


	ClickNTimeMid('txtbxCMND.bmp',2)
	Send('045216985315')


	ClickNTimeMid('txtbxMatKhau.bmp',2)
	Send('aejv7412')


	ClickNTimeMid('txtbxSoDienThoai.bmp',2)
	Send('0914568823')


	ClickNTimeMid('txtbxDiaChi.bmp',2)
	Send('123 Nguyen Dinh Chieu')


	ClickNTimeMid('txtbxEmail.bmp',2)
	Send('email@mail.com')

	ClickNTimeMid('btnOK.bmp',1)
	Sleep(1000)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(1000)

EndFunc

Func UTCID_AddEmployee_03()

	ClickNTimeMid('txtbxHoVaTen.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxLuong.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxMaNhanVien.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxCMND.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxMatKhau.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxSoDienThoai.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxDiaChi.bmp',2)
	Send('5j')


	ClickNTimeMid('txtbxEmail.bmp',2)
	Send('5j')


	ClickNTimeMid('btnOK.bmp',1)
	Sleep(1000)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(1000)

EndFunc

Func UTCID_UpdateEmployee_01()

	ClickNTimeNextTo('lblMaNV.bmp',1,30,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,30,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,30,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,30,15)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('aejv7412')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_02()

	ClickNTimeNextTo('lblMaNV.bmp',2,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',2,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',2,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',2,150,15*1)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('aejv7412')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_03()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*2)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('nguyen van c')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_04()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*6)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('email@mail.com')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_05()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*7)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('840000')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_06()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
  	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*5)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('0914568823')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_07()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*3)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('045216985315')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_08()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*4)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('123 Nguyen Dinh Chieu')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_09()

	ClickNTimeNextTo('lblMaNV.bmp',2,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',2,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',2,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',2,150,15*1)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc


Func UTCID_UpdateEmployee_10()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*2)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_11()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*6)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_12()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*7)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_13()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
  	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*5)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_14()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*3)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateEmployee_15()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*4)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc


Func UTCID_DeleteEmployee_01()

	UNTCID_DeleteEmployee('ST005.bmp')
	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_DeleteEmployee_02()


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc


Func UTCID_AddCustomer_01()

	ClickNTimeMid('txtbxHoTen.bmp',2)
	Send('Nguyen Thi R')


	ClickNTimeMid('txtbxMaKH.bmp',2)
	Send('KH50')


	ClickNTimeMid('txtbxCMND.bmp',2)
	Send('025614992257')


	ClickNTimeMid('txtbxSoDienThoai.bmp',2)
	Send('0986647512')


	ClickNTimeMid('txtbxDiaChi.bmp',2)
	Send('45/8A Pham Van Dong')


	ClickNTimeMid('btnThem.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi_KH.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_AddCustomer_02()

	ClickNTimeMid('txtbxHoTen.bmp',2)
	Send('Nguyen Thi R')


	ClickNTimeMid('txtbxMaKH.bmp',2)
	Send('KH01')


	ClickNTimeMid('txtbxCMND.bmp',2)
	Send('025614992257')


	ClickNTimeMid('txtbxSoDienThoai.bmp',2)
	Send('0986647512')


	ClickNTimeMid('txtbxDiaChi.bmp',2)
	Send('45/8A Pham Van Dong')


	ClickNTimeMid('btnThem.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(1000)


	ClickNTimeMid('btnTaiMoi_KH.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_AddCustomer_03()

	ClickNTimeMid('txtbxHoTen.bmp',2)
	Send('5t')


	ClickNTimeMid('txtbxMaKH.bmp',2)
	Send('5t')


	ClickNTimeMid('txtbxCMND.bmp',2)
	Send('5t')


	ClickNTimeMid('txtbxSoDienThoai.bmp',2)
	Send('5t')


	ClickNTimeMid('txtbxDiaChi.bmp',2)
	Send('5t')


	ClickNTimeMid('btnThem.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(1000)


	ClickNTimeMid('btnTaiMoi_KH.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_AddCustomer_04()

	ClickNTimeMid('btnTaiThem.bmp',1)
	Sleep(500)

	ClickNTimeMid('btnTaiMoi_KH.bmp',1)
	Sleep(500)

	ClickNTimeMid('OK.bmp',1)
	Sleep(1000)


	ClickNTimeMid('btnTaiMoi_KH.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_UpdateCustomer_01()

	ClickNTimeNextTo('lblMaKH.bmp',1,30,0)
	ClickNTimeNextTo('lblMaKH.bmp',1,30,0)

	ClickNTimeNextTo('lblThongTin.bmp',1,30,0)
	ClickNTimeNextTo('lblMaKH.bmp',1,30,0)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('aejv7412')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_02()

	ClickNTimeNextTo('lblMaKH.bmp',2,150,0)
	ClickNTimeNextTo('lblMaKH.bmp',2,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',2,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',2,150,15*1)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('aejv7412')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_03()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*2)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('nguyen van c')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_04()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*6)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('email@mail.com')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_05()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*7)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('840000')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_06()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
  	ClickNTimeNextTo('lblThongTin.bmp',1,150,5+ 15*5)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('0914568823')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_07()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*3)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('045216985315')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_08()

	ClickNTimeNextTo('lblMaNV.bmp',1,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',1,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',1,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',1,150,15*4)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('123 Nguyen Dinh Chieu')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_UpdateCustomer_09()

	ClickNTimeNextTo('lblMaNV.bmp',2,150,0)
	ClickNTimeNextTo('lblMaNV.bmp',2,150,15)

	ClickNTimeNextTo('lblThongTin.bmp',2,150,0)
	ClickNTimeNextTo('lblThongTin.bmp',2,150,15*1)

	ClickNTimeNextTo('lblDuLieuMoi.bmp',2,150,0)
	Send('')

	ClickNTimeMid('btnUpdate.bmp',1)
	Sleep(1000)

	ClickNTimeMid('OK.bmp',1)
	Sleep(500)


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_DeleteCustomer_01()

	UNTCID_DeleteCustomer('KH50.bmp')
	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_DeleteCustomer_02()


	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)


EndFunc

Func UTCID_ImportGood_01()

	ClickNTimeMid('txtbxTenSanPham.bmp',2)
	Send('Choi lau nha')


	ClickNTimeMid('txtbxMaSanPham.bmp',2)
	Send('GD011')


	ClickNTimeMid('txtbxGia.bmp',2)
	Send('40000')


	ClickNTimeMid('txtbxSL.bmp',2)
	Send('60')


	ClickNTimeMid('txtbxNuocSanXuat.bmp',2)
	Send('Viet Nam')

	ClickNTimeMid('btnOK.bmp',1)

	Sleep(500)

	ClickNTimeMid('OK.bmp',1)

	Sleep(500)

	ClickNTimeMid('btnTaiMoi.bmp',1)

EndFunc

Func UTCID_ImportGood_02()

	ClickNTimeMid('txtbxTenSanPham.bmp',2)
	Send('Choi lau nha')


	ClickNTimeMid('txtbxMaSanPham.bmp',2)
	Send('GD001')


	ClickNTimeMid('txtbxGia.bmp',2)
	Send('40000')


	ClickNTimeMid('txtbxSL.bmp',2)
	Send('60')


	ClickNTimeMid('txtbxNuocSanXuat.bmp',2)
	Send('Viet Nam')


	ClickNTimeMid('btnOK.bmp',1)

	Sleep(500)

	ClickNTimeMid('OK.bmp',1)

	Sleep(500)

	ClickNTimeMid('btnTaiMoi.bmp',1)


EndFunc

Func UTCID_ImportGood_03()

	ClickNTimeMid('txtbxTenSanPham.bmp',2)
	Send('7rt9')


	ClickNTimeMid('txtbxMaSanPham.bmp',2)
	Send('7rt9')


	ClickNTimeMid('txtbxGia.bmp',2)
	Send('7rt9')


	ClickNTimeMid('txtbxSL.bmp',2)
	Send('7rt9')


	ClickNTimeMid('txtbxNuocSanXuat.bmp',2)
	Send('7rt9')


	ClickNTimeMid('btnOK.bmp',1)

	Sleep(500)

	ClickNTimeMid('OK.bmp',1)

	Sleep(500)

	ClickNTimeMid('btnTaiMoi.bmp',1)

EndFunc

Func UTCID_ImportGood_04()

	ClickNTimeMid('btnTaiMoi.bmp',1)

	ClickNTimeMid('btnOK.bmp',1)

	Sleep(500)

	ClickNTimeMid('OK.bmp',1)

	Sleep(500)

	ClickNTimeMid('btnTaiMoi.bmp',1)

EndFunc

Func UTCID_DeleteProduct_01()

	UNTCID_DeleteProduct('GD011.bmp')
	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_DeleteProduct_02()

	ClickNTimeMid('btnTaiMoi.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_AddToCart_01()



	ClickNTimeMid('btnThem_BanHang.bmp',1)


EndFunc

Func UTCID_AddToCart_02()

	ClickNTimeNextTo('lblMaSanPham.bmp',1,320,0)

	ClickNTimeNextTo('lblMaSanPham.bmp',1,320,15*5)

	ClickNTimeNextTo('lblSoLuong.bmp',2,250,0)
	Send('30')

	ClickNTimeMid('btnThem_BanHang.bmp',1)


EndFunc

Func UTCID_AddToCart_03()



	ClickNTimeNextTo('lblMaSanPham.bmp',1,320,0)

	ClickNTimeNextTo('lblMaSanPham.bmp',1,320,15*6)

	ClickNTimeNextTo('lblSoLuong.bmp',2,250,0)
	Send('30')

	ClickNTimeMid('btnThem_BanHang.bmp',1)



EndFunc

Func UTCID_AddToCart_04()


	ClickNTimeNextTo('lblMaSanPham.bmp',1,320,0)

	ClickNTimeNextTo('lblMaSanPham.bmp',1,320,15*6)

	ClickNTimeNextTo('lblSoLuong.bmp',2,250,0)
	Send('9300')

	ClickNTimeMid('btnThem_BanHang.bmp',1)


EndFunc

Func UTCID_SellingGood_01()

	UTCID_AddToCart_03()

	ClickNTimeNextTo('lblMaKhachHang.bmp',2,250,0)

	Send('KH02')

	ClickNTimeNextTo('lblTienNhan.bmp',2,200,0)

	Send('2500000')

	ClickNTimeMid('btnTinhTien.bmp',1)


	ClickNTimeMid('Yes.bmp',1)

	Sleep(500)

	ClickNTimeMid('OK.bmp',1)

EndFunc

Func UTCID_SellingGood_02()


	UTCID_AddToCart_03()

	ClickNTimeNextTo('lblMaKhachHang.bmp',2,250,0)

	Send('KH02')

	ClickNTimeNextTo('lblTienNhan.bmp',2,200,0)

	Send('2000000')


	ClickNTimeMid('btnTinhTien.bmp',1)

	ClickNTimeMid('Yes.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_SellingGood_03()


	ClickNTimeMid('btnTinhTien.bmp',1)

	ClickNTimeMid('Yes.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_SellingGood_04()


	UTCID_AddToCart_03()

	ClickNTimeNextTo('lblMaKhachHang.bmp',2,250,0)

	Send('')

	ClickNTimeNextTo('lblTienNhan.bmp',2,200,0)

	Send('2500000')


	ClickNTimeMid('btnTinhTien.bmp',1)

	ClickNTimeMid('Yes.bmp',1)
	Sleep(500)

EndFunc

Func UTCID_RemoveOutOfCart_01()


	UTCID_AddToCart_03()

	ClickNTimeMid('btnRemoveOutOfCart.bmp',1)

	Sleep(500)

EndFunc


Func UTCID_SellingGood_05()

	ClickNTimeMid('btnThem_BanHang.bmp',1)


EndFunc

Func StartAutomate()
	Run(@ScriptDir&'\bin\Debug\UserForm1.exe')
        If WinActivate ( "Form1" ,'') Then
			Sleep(2000)
	;UTCID_Login_05()
	;UTCID_Login_04()
	;UTCID_Login_03()
	;UTCID_Login_02()
	;LoginForm('FDangXuat.bmp')
	UTCID_Login_01()

	;LoginForm('FNhanVien.bmp')
	;UTCID_AddEmployee_01()
	;UNTCID_DeleteEmployee('ST003.bmp')
	;UTCID_AddEmployee_02()
	;UTCID_AddEmployee_03()
	;UTCID_AddEmployee_04()


	;ClickNTimeMid('Exit.bmp',1)
	;Sleep(300)

	LoginForm('FKhachHang.bmp')
	;UTCID_AddCustomer_01()
	;UNTCID_DeleteCustomer('KH50.bmp')
	UTCID_AddCustomer_02()
	;UTCID_AddCustomer_03()
	;UTCID_AddCustomer_04()

	ClickNTimeMid('Exit.bmp',1)
	Sleep(300)

	;LoginForm('FKho.bmp')

	;UTCID_ImportGood_01()
	;UNTCID_DeleteProduct('GD011.bmp')
	;UTCID_ImportGood_02()
	;UTCID_ImportGood_03()
	;UTCID_ImportGood_04()

	ClickNTimeMid('Exit.bmp',1)
	Sleep(300)

	;LoginForm('FThongKe.bmp')
	;Sleep(2000)

	;ClickNTimeMid('Exit.bmp',1)
	;Sleep(300)

	;LoginForm('FHoaDon.bmp')
	;Sleep(2000)

	;ClickNTimeMid('Exit.bmp',1)
	;Sleep(300)

	LoginForm('FDangXuat.bmp')


Else
	MsgBox(0,'win failed','Window not found',4)

	EndIf
	EndFunc

Func StartWindow()
	Run(@ScriptDir&'\bin\Debug\UserForm1.exe')
        If WinActivate ( "Form1" ,'') Then
			Sleep(2000)
			Else
	MsgBox(0,'win failed','Window not found',4)

	EndIf
	EndFunc

#Region ### START Koda GUI section ### Form=
$Form1 = GUICreate("Form1", 615, 437, 192, 124)
$Button1 = GUICtrlCreateButton("", 550, 400, 30, 30)

$TreeViewMain = GUICtrlCreateTreeView(40, 32, 529, 361)
$TreeViewMain_0 = GUICtrlCreateTreeViewItem("Employee Management", $TreeViewMain)
$TreeViewMain_1 = GUICtrlCreateTreeViewItem("UTCID_AddEmployee_01", $TreeViewMain_0)
$TreeViewMain_2 = GUICtrlCreateTreeViewItem("UTCID_AddEmployee_02", $TreeViewMain_0)
$TreeViewMain_3 = GUICtrlCreateTreeViewItem("UTCID_AddEmployee_03", $TreeViewMain_0)
$TreeViewMain_4 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_01", $TreeViewMain_0)
$TreeViewMain_5 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_02", $TreeViewMain_0)
$TreeViewMain_6 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_03", $TreeViewMain_0)
$TreeViewMain_7 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_04", $TreeViewMain_0)
$TreeViewMain_8 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_05", $TreeViewMain_0)
$TreeViewMain_9 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_06", $TreeViewMain_0)
$TreeViewMain_10 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_07", $TreeViewMain_0)
$TreeViewMain_11 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_08", $TreeViewMain_0)
$TreeViewMain_12 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_09", $TreeViewMain_0)
$TreeViewMain_13 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_10", $TreeViewMain_0)
$TreeViewMain_14 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_11", $TreeViewMain_0)
$TreeViewMain_15 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_12", $TreeViewMain_0)
$TreeViewMain_16 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_13", $TreeViewMain_0)
$TreeViewMain_17 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_14", $TreeViewMain_0)
$TreeViewMain_18 = GUICtrlCreateTreeViewItem("UTCID_UpdateEmployee_15", $TreeViewMain_0)
$TreeViewMain_19 = GUICtrlCreateTreeViewItem("UTCID_DeleteEmployee_01", $TreeViewMain_0)
$TreeViewMain_20 = GUICtrlCreateTreeViewItem("UTCID_DeleteEmployee_02", $TreeViewMain_0)
$TreeViewMain_21 = GUICtrlCreateTreeViewItem("", $TreeViewMain_0)
$TreeViewMain_22 = GUICtrlCreateTreeViewItem("CustomerManagement", $TreeViewMain)
$TreeViewMain_23 = GUICtrlCreateTreeViewItem("UTCID_AddCustomer_01", $TreeViewMain_22)
$TreeViewMain_24 = GUICtrlCreateTreeViewItem("UTCID_AddCustomer_02", $TreeViewMain_22)
$TreeViewMain_25 = GUICtrlCreateTreeViewItem("UTCID_AddCustomer_03", $TreeViewMain_22)
$TreeViewMain_26 = GUICtrlCreateTreeViewItem("UTCID_AddCustomer_04", $TreeViewMain_22)
$TreeViewMain_27 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_01", $TreeViewMain_22)
$TreeViewMain_28 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_02", $TreeViewMain_22)
$TreeViewMain_29 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_03", $TreeViewMain_22)
$TreeViewMain_30 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_04", $TreeViewMain_22)
$TreeViewMain_31 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_05", $TreeViewMain_22)
$TreeViewMain_32 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_06", $TreeViewMain_22)
$TreeViewMain_33 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_07", $TreeViewMain_22)
$TreeViewMain_34 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_08", $TreeViewMain_22)
$TreeViewMain_35 = GUICtrlCreateTreeViewItem("UTCID_UpdateCustomer_09", $TreeViewMain_22)
$TreeViewMain_36 = GUICtrlCreateTreeViewItem("UTCID_DeleteCustomer_01", $TreeViewMain_22)
$TreeViewMain_37 = GUICtrlCreateTreeViewItem("UTCID_DeleteCustomer_02", $TreeViewMain_22)
$TreeViewMain_38 = GUICtrlCreateTreeViewItem("", $TreeViewMain_22)
$TreeViewMain_39 = GUICtrlCreateTreeViewItem("Login", $TreeViewMain)
$TreeViewMain_40 = GUICtrlCreateTreeViewItem("UTCID_Login_01", $TreeViewMain_39)
$TreeViewMain_41 = GUICtrlCreateTreeViewItem("UTCID_Login_02", $TreeViewMain_39)
$TreeViewMain_42 = GUICtrlCreateTreeViewItem("UTCID_Login_03", $TreeViewMain_39)
$TreeViewMain_43 = GUICtrlCreateTreeViewItem("UTCID_Login_04", $TreeViewMain_39)
$TreeViewMain_44 = GUICtrlCreateTreeViewItem("UTCID_Login_05", $TreeViewMain_39)
$TreeViewMain_45 = GUICtrlCreateTreeViewItem("", $TreeViewMain_39)
$TreeViewMain_46 = GUICtrlCreateTreeViewItem("ImportGood", $TreeViewMain)
$TreeViewMain_47 = GUICtrlCreateTreeViewItem("UTCID_ImportGood_01", $TreeViewMain_46)
$TreeViewMain_48 = GUICtrlCreateTreeViewItem("UTCID_ImportGood_02", $TreeViewMain_46)
$TreeViewMain_49 = GUICtrlCreateTreeViewItem("UTCID_ImportGood_03", $TreeViewMain_46)
$TreeViewMain_50 = GUICtrlCreateTreeViewItem("UTCID_ImportGood_04", $TreeViewMain_46)
$TreeViewMain_51 = GUICtrlCreateTreeViewItem("UTCID_DeleteProduct_01", $TreeViewMain_46)
$TreeViewMain_52 = GUICtrlCreateTreeViewItem("UTCID_DeleteProduct_01", $TreeViewMain_46)
$TreeViewMain_53 = GUICtrlCreateTreeViewItem("", $TreeViewMain_46)
$TreeViewMain_54 = GUICtrlCreateTreeViewItem("SellingGood", $TreeViewMain)
$TreeViewMain_55 = GUICtrlCreateTreeViewItem("UTCID_AddToCart_01", $TreeViewMain_54)
$TreeViewMain_56 = GUICtrlCreateTreeViewItem("UTCID_AddToCart_02", $TreeViewMain_54)
$TreeViewMain_57 = GUICtrlCreateTreeViewItem("UTCID_AddToCart_03", $TreeViewMain_54)
$TreeViewMain_58 = GUICtrlCreateTreeViewItem("UTCID_AddToCart_04", $TreeViewMain_54)
$TreeViewMain_59 = GUICtrlCreateTreeViewItem("UTCID_SellingGood_01", $TreeViewMain_54)
$TreeViewMain_60 = GUICtrlCreateTreeViewItem("UTCID_SellingGood_02", $TreeViewMain_54)
$TreeViewMain_61 = GUICtrlCreateTreeViewItem("UTCID_SellingGood_03", $TreeViewMain_54)
$TreeViewMain_62 = GUICtrlCreateTreeViewItem("UTCID_SellingGood_04", $TreeViewMain_54)
$TreeViewMain_63 = GUICtrlCreateTreeViewItem("UTCID_RemoveOutOfcart_01", $TreeViewMain_54)
$TreeViewMain_64 = GUICtrlCreateTreeViewItem("", $TreeViewMain_54)
GUISetState(@SW_SHOW)
#EndRegion ### END Koda GUI section ###


StartWindow()

While 1
	$nMsg = GUIGetMsg()
	Switch $nMsg
		Case $GUI_EVENT_CLOSE
			Exit

		Case $TreeViewMain_1
			LoginForm('FNhanVien.bmp')
			UTCID_AddEmployee_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_2
			LoginForm('FNhanVien.bmp')
			UTCID_AddEmployee_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_3

			LoginForm('FNhanVien.bmp')
			UTCID_AddEmployee_03()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_4

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_5

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_6

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_03()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_7

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_04()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_8

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_05()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_9

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_06()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_10

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_07()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_11

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_08()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_12

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_09()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_13

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_10()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_14

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_11()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_15

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_12()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_16

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_13()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_17

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_14()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_18

			LoginForm('FNhanVien.bmp')
			UTCID_UpdateEmployee_15()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_19

			LoginForm('FNhanVien.bmp')
			UTCID_DeleteEmployee_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_20

			LoginForm('FNhanVien.bmp')
			UTCID_DeleteEmployee_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_23

			LoginForm('FKhachHang.bmp')
			UTCID_AddCustomer_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_24

			LoginForm('FKhachHang.bmp')
			UTCID_AddCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_25

			LoginForm('FKhachHang.bmp')
			UTCID_AddCustomer_03()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_26

			LoginForm('FKhachHang.bmp')
			UTCID_AddCustomer_04()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_27

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_28

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_29

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_30

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_31

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_32

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_33

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_34

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_35

			LoginForm('FKhachHang.bmp')
			UTCID_UpdateCustomer_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_36

			LoginForm('FKhachHang.bmp')
			UTCID_DeleteCustomer_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_37

			LoginForm('FKhachHang.bmp')
			UTCID_DeleteCustomer_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_40
			UTCID_Login_01()

		Case $TreeViewMain_41
			UTCID_Login_02()

		Case $TreeViewMain_42
			UTCID_Login_03()

		Case $TreeViewMain_43
			UTCID_Login_04()

		Case $TreeViewMain_44
			UTCID_Login_05()

		Case $TreeViewMain_47

			LoginForm('FKho.bmp')
			UTCID_ImportGood_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_48

			LoginForm('FKho.bmp')
			UTCID_ImportGood_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_49

			LoginForm('FKho.bmp')
			UTCID_ImportGood_03()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_50

			LoginForm('FKho.bmp')
			UTCID_ImportGood_04()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_51

			LoginForm('FKho.bmp')
			UTCID_DeleteProduct_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_52

			LoginForm('FKho.bmp')
			UTCID_DeleteProduct_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_55

			LoginForm('FBanHang.bmp')
			UTCID_AddToCart_01()
;~ 			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_56
			LoginForm('FBanHang.bmp')
			UTCID_AddToCart_02()
;~ 			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_57
			LoginForm('FBanHang.bmp')
			UTCID_AddToCart_03()
;~ 			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_58
			LoginForm('FBanHang.bmp')
			UTCID_AddToCart_04()
;~ 			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_59

			LoginForm('FBanHang.bmp')
			UTCID_SellingGood_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_60

			LoginForm('FBanHang.bmp')
			UTCID_SellingGood_02()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_61

			LoginForm('FBanHang.bmp')
			UTCID_SellingGood_03()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_62

			LoginForm('FBanHang.bmp')
			UTCID_SellingGood_04()
			ClickNTimeMid('Exit.bmp',1)

		Case $TreeViewMain_63

			LoginForm('FBanHang.bmp')
			UTCID_RemoveOutOfCart_01()
			ClickNTimeMid('Exit.bmp',1)

		Case $Button1
			Prize()

	EndSwitch
WEnd


#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.16.0
 Author:         myName

 Script Function:
	Template AutoIt script.

#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here
