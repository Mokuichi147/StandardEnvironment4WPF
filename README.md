# Standard environment for WPF

Windowsの標準環境でWPFをコンパイルします。


# 環境

- OS
    - Windows 10 or 11
- コンパイラ
    - csc.exe
- 言語関連
    - C# (.Net Framework)
    - WPF
    - XAML


# コンパイル

```
./build.bat
```


# 実行

```
./se4wpf.exe
```

# コンパイルが通らない場合

- XAMLに日本語が含まれている場合  
    1. xamlファイルを `メモ帳` で開く。
    2. `ファイル > 名前を付けて保存` から `UFT-8` で保存する。