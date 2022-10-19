# 第1次隨堂-隨堂-QZ1
>
>學號：109111124
><br />
>姓名：蔡巧柔 
><br />
>作業撰寫時間：120 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/10/19
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x] 說明內容
- [x] 個人認為完成作業須具備觀念

## 說明程式與內容

建立一個陣列儲存炸彈，再使用for迴圈建立int陣列，再生成一個存放字元的二維陣列變數大小為10*10，並讓for迴圈使所有二維陣列字元為o，再迴圈訪問處存炸彈的陣列時將字元o替換成字元*，最後使for迴圈列印出結果，
下段程式碼則為使用後結果：

```csharp
protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_MIndex = new int[10] {0, 7, 13, 28, 44, 62, 74, 75, 87, 90};
            char[,] ia_Map = new char[10, 10];
            for (int Row = 0; Row < 10; Row++)
            {
                for(int Col = 0; Col < 10; Col++)
                {
                    ia_Map[Row, Col] = '0';
                }
            }
            for (int Ct = 0; Ct < 10; Ct++)
            {
                int Row = ia_MIndex[Ct] / 10;
                int Col = ia_MIndex[Ct] % 10;
                ia_Map[Row, Col] = '*';
            }           
            for (int Row = 0; Row < 10; Row++)
            {
                for (int Col = 0; Col < 10; Col++)
                {
                    Response.Write(ia_Map[Row, Col]);
                }
                Response.Write("<br />");
            }
        }
```

下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bomb.aspx.cs" Inherits="_111_1QZ1.Bomb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

需了解題目要求及邏輯判斷，並使用for迴圈寫巢狀結構，其中關於迴圈及陣列的運用需了解其意義及用法，否則很容易發生錯誤。

