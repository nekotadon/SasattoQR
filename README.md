# SasattoQR

## 概要

<img width="768"  src="./image/img.gif">

QRコードの作成と読み取りを行うソフトウェアです。  
* 作成モード  
左の枠内の文字列をQRコードに変換します。  

* 読み取りモード  
読み取りモードにすると右の枠内が透過します。  
ソフトウェアを移動したり、サイズを変更したりして、右の枠内にQRコードが入るようにしてから読み取りボタンを押してください。 

## 動作確認環境
Microsoft Windows10 x64 + .NET Framework 4.8

## その他

### ZXing.Netについて

本ソフトウェアはQRコードの作成、読み取りのために以下のライブラリを使用しています。  

* `zxing.dll`  
* `zxing.presentation.dll`  

ライセンスについてはZXing.Netフォルダ内のCOPYINGを確認願います。  

ZXing.Net  
Michael Jahn  
https://github.com/micjahn/ZXing.Net/  
Apache License Version 2.0  
http://www.apache.org/licenses/LICENSE-2.0  

### QRコードについて

QRコードは株式会社デンソーウェーブの登録商標です。
