/* 全局樣式：去掉預設的 margin 和 padding */
* {
    margin: 0;
    padding: 0;
}

/* 網頁的基本樣式 */
body {
    font-family: Arial, sans-serif;
    background-color: #f2f2a9;
    padding: 20px;
}

/* 標題樣式 */
h1 {
    color: #526930;
    text-align: center;
    margin-bottom: 20px;
}

/* 導覽列樣式 */
.nav {
    text-align: center;
    margin-bottom: 20px;
}

.nav a {
    text-decoration: none;
    color: #fff;
    background-color: #9aaa56;
    padding: 10px 15px;
    margin: 0 5px;
}

/* 大圖片樣式 */
.main-image img {
    display: block;
    margin: 0 auto;
    width: 600px;
}

/* 蔬菜圖片和聯絡資訊水平排版 */
.content-row {
    display: flex; /* 使用 Flexbox 來讓蔬菜圖片區和聯絡資訊水平排列 */
    justify-content: space-between; /* 讓兩個區塊之間有一定的距離 */
    margin-top: 20px;
}

/* 蔬菜圖片區 */
.vegetables img {
    width: 150px;
    margin-right: 10px; /* 圖片之間的距離 */
}

.vegetables {
    display: flex; /* 讓蔬菜圖片橫向排列 */
}

/* 聯絡資訊區 */
.contact {
    max-width: 200px; /* 控制聯絡資訊區的寬度，防止它太寬 */
}

h2 {
    margin-bottom: 10px;
}

p {
    margin-bottom: 10px;
}
