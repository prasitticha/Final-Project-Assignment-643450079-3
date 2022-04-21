# Final-Project-Assignment-643450079-3

### ความเป็นมาของโปรแกรม
โปรแกรมสร้างขึ้นเพื่อให้บุคคลที่ต้องการเช็คสินค้าตนเองทำไปใช้ได้

### วัตถุประสงค์ของโปรแกรม
จัดทำขึ้นเพื่อให้บุคคลหรือร้านค้าร้านสะดวกซื้อและโรงงานที่สนใจจะเช็คสินค้าของตนเองนำไปใช้ได้

### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Program <|-- Form1
    Form1 <|-- Form2
    Form2 <|-- Product
    Form2 <|-- Calculator
    Program : +Main()
    class Form1{
        +buttonLogin_Click();
        +buttonExit_Click();
    }
    class Form2{
        +openToolStripMenuItem_Click();
        +saveToolStripMenuItem_Click();
        +logoutToolStripMenuItem_Click();
        +exitProgramToolStripMenuItem_Click();
        +button_Import_Click();
        +button_Update_Click();
        +dataGridView1_CellClick();
        +timer1_Tick();
        +button_Delete_Click();
    }
    class Product{
        -_ProductCode;
        -_List;
        -_INputProduct;
        -_OPTputProduct;
        +ProductCode();
        +List();
        +INputProduct();
        +OPTputProduct();
    }
    class Calculator{
        -sum12;
        -sum34;
        +addCalculator();
        +getCalculator();
        +addCalculatorUpdate();
        +getCalculatorUpdate();
    }
```

### ผู้พัฒนาโปรแกรม
นายประสิทธิชัย จันทร์สม 643450079-3
