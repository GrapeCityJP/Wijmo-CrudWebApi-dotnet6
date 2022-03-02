# Wijmo-CrudWebApi-dotnet6
2022年3月2日に実施したオンラインセミナー「WijmoでCRUD処理を行うWebアプリケーションを作ってみよう！」で作成したプロジェクトです。

# サンプル起動方法

## データベースの構築
ローカル環境にMySQLをインストールし、コマンドプロンプトなどから以下のコマンドを実行しログインします。  
参考情報：[Wijmo & SpringでつくるCRUDアプリケーション（1）環境構築編](https://devlog.grapecity.co.jp/wijmo-and-spring-setup/)
```
mysql -u root -p
```
以下のコマンドを実行し、「test2022」データベースを作成し、使用するデータベースとして選択します。  
```
CREATE DATABASE test2022;  
USE test2022
```
以下のコマンドを実行し、「orders」テーブルを作成します。  
```
CREATE TABLE orders (id INT, customer VARCHAR(256), staff VARCHAR(256), product VARCHAR(256), unitprice INT, number INT, price INT);
```
以下のコマンドを実行し、主キーを設定します。  
```
ALTER TABLE orders ADD PRIMARY KEY (id);
```
  
以下のコマンドを実行しテストデータを登録します。  

```
INSERT INTO orders VALUES (1,'洋風居酒屋けい・えっくす','高橋 真紀','果汁100% グレープ', 1200, 100, 120000);
INSERT INTO orders VALUES (2,'イルカランド','正門 恵子','果汁100% オレンジ', 1000, 50, 50000);
INSERT INTO orders VALUES (3,'惣菜びみ','東海 誠一','コーヒー マイルド', 1500, 100, 150000);
INSERT INTO orders VALUES (4,'寿ストアー','高橋 真紀','コーヒー ミルク', 1600, 150, 240000);
INSERT INTO orders VALUES (5,'商店せんしょう','森上 偉久馬','果汁100% グレープ', 1200, 300, 360000);
INSERT INTO orders VALUES (6,'甘味喫茶ダイ','森上 偉久馬','果汁100% パイナップル', 1400, 70, 98000);
INSERT INTO orders VALUES (7,'酒蔵でん','松沢 彩子','コーヒー 無糖', 1500, 300, 450000);
INSERT INTO orders VALUES (8,'洋食ちくさ','田中 秀樹','コーヒー ビター', 1500, 200, 300000);
INSERT INTO orders VALUES (9,'大和マーケット','東海 誠一','果汁100% オレンジ', 1000, 30, 30000);
INSERT INTO orders VALUES (10,'アリス亭','森上 偉久馬','果汁100% りんご', 1100, 60, 66000);
```
## Web APIの起動
1. `webinar0302`のプロジェクトをVisual Studioで開き、`appsettings.json`内の接続文字列中の`password`の値を環境にあわせて変更します。
2. プロジェクトを実行するとローカル環境のMySQLと連携するWeb APIが起動できます。

## クライアントアプリの起動
1. `wijmo-app`のプロジェクトをVisual Studio Codeで開き、`index.html`内のURL起動しているWeb APIのものに変更します。
2. 拡張機能の[Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer)を使用して`index.html`を開くと、Web APIから取得したデータを画面のFlexGrid上に表示できます。
