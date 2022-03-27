
namespace Magazin
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label pRODUCTSNAMELabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label pRICELabel;
            System.Windows.Forms.Label nUMBERLabel;
            System.Windows.Forms.Label oRDERTIMELabel;
            System.Windows.Forms.Label uSERSURNAMELabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label eMPLOYEESURNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pRODUCTSNAMETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.nUMBERTextBox = new System.Windows.Forms.TextBox();
            this.oRDERTIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uSERSURNAMETextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pATRONYMICTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEESURNAMETextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.viewORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computer_ShopDataSet = new Magazin.Computer_ShopDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Magazin.Computer_ShopDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Magazin.Computer_ShopDataSetTableAdapters.TableAdapterManager();
            this.viewORDERTableAdapter = new Magazin.Computer_ShopDataSetTableAdapters.ViewORDERTableAdapter();
            label1 = new System.Windows.Forms.Label();
            pRODUCTSNAMELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            nUMBERLabel = new System.Windows.Forms.Label();
            oRDERTIMELabel = new System.Windows.Forms.Label();
            uSERSURNAMELabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            eMPLOYEESURNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_ShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.MidnightBlue;
            label1.Location = new System.Drawing.Point(51, 271);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 16);
            label1.TabIndex = 44;
            label1.Text = "Сумма заказа";
            // 
            // pRODUCTSNAMELabel
            // 
            pRODUCTSNAMELabel.AutoSize = true;
            pRODUCTSNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pRODUCTSNAMELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            pRODUCTSNAMELabel.Location = new System.Drawing.Point(45, 64);
            pRODUCTSNAMELabel.Name = "pRODUCTSNAMELabel";
            pRODUCTSNAMELabel.Size = new System.Drawing.Size(119, 16);
            pRODUCTSNAMELabel.TabIndex = 26;
            pRODUCTSNAMELabel.Text = "Наименование";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dESCRIPTIONLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(83, 88);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(81, 16);
            dESCRIPTIONLabel.TabIndex = 28;
            dESCRIPTIONLabel.Text = "Описание";
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pRICELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            pRICELabel.Location = new System.Drawing.Point(119, 114);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(45, 16);
            pRICELabel.TabIndex = 30;
            pRICELabel.Text = "Цена";
            // 
            // nUMBERLabel
            // 
            nUMBERLabel.AutoSize = true;
            nUMBERLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nUMBERLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            nUMBERLabel.Location = new System.Drawing.Point(68, 140);
            nUMBERLabel.Name = "nUMBERLabel";
            nUMBERLabel.Size = new System.Drawing.Size(96, 16);
            nUMBERLabel.TabIndex = 32;
            nUMBERLabel.Text = "Количество";
            // 
            // oRDERTIMELabel
            // 
            oRDERTIMELabel.AutoSize = true;
            oRDERTIMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oRDERTIMELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            oRDERTIMELabel.Location = new System.Drawing.Point(63, 165);
            oRDERTIMELabel.Name = "oRDERTIMELabel";
            oRDERTIMELabel.Size = new System.Drawing.Size(101, 16);
            oRDERTIMELabel.TabIndex = 34;
            oRDERTIMELabel.Text = "Дата заказа";
            // 
            // uSERSURNAMELabel
            // 
            uSERSURNAMELabel.AutoSize = true;
            uSERSURNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            uSERSURNAMELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            uSERSURNAMELabel.Location = new System.Drawing.Point(39, 192);
            uSERSURNAMELabel.Name = "uSERSURNAMELabel";
            uSERSURNAMELabel.Size = new System.Drawing.Size(42, 16);
            uSERSURNAMELabel.TabIndex = 36;
            uSERSURNAMELabel.Text = "ФИО";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pHONELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            pHONELabel.Location = new System.Drawing.Point(89, 218);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(75, 16);
            pHONELabel.TabIndex = 40;
            pHONELabel.Text = "Телефон";
            // 
            // eMPLOYEESURNAMELabel
            // 
            eMPLOYEESURNAMELabel.AutoSize = true;
            eMPLOYEESURNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            eMPLOYEESURNAMELabel.ForeColor = System.Drawing.Color.MidnightBlue;
            eMPLOYEESURNAMELabel.Location = new System.Drawing.Point(76, 244);
            eMPLOYEESURNAMELabel.Name = "eMPLOYEESURNAMELabel";
            eMPLOYEESURNAMELabel.Size = new System.Drawing.Size(88, 16);
            eMPLOYEESURNAMELabel.TabIndex = 42;
            eMPLOYEESURNAMELabel.Text = "Сотрудник";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "ORDERSUM", true));
            this.textBox1.Location = new System.Drawing.Point(170, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 45;
            // 
            // pRODUCTSNAMETextBox
            // 
            this.pRODUCTSNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PRODUCTSNAME", true));
            this.pRODUCTSNAMETextBox.Location = new System.Drawing.Point(170, 61);
            this.pRODUCTSNAMETextBox.Name = "pRODUCTSNAMETextBox";
            this.pRODUCTSNAMETextBox.Size = new System.Drawing.Size(203, 20);
            this.pRODUCTSNAMETextBox.TabIndex = 27;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(170, 87);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(203, 20);
            this.dESCRIPTIONTextBox.TabIndex = 29;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(170, 113);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(203, 20);
            this.pRICETextBox.TabIndex = 31;
            // 
            // nUMBERTextBox
            // 
            this.nUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "NUMBER", true));
            this.nUMBERTextBox.Location = new System.Drawing.Point(170, 139);
            this.nUMBERTextBox.Name = "nUMBERTextBox";
            this.nUMBERTextBox.Size = new System.Drawing.Size(203, 20);
            this.nUMBERTextBox.TabIndex = 33;
            // 
            // oRDERTIMEDateTimePicker
            // 
            this.oRDERTIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewORDERBindingSource, "ORDERTIME", true));
            this.oRDERTIMEDateTimePicker.Location = new System.Drawing.Point(170, 165);
            this.oRDERTIMEDateTimePicker.Name = "oRDERTIMEDateTimePicker";
            this.oRDERTIMEDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.oRDERTIMEDateTimePicker.TabIndex = 35;
            // 
            // uSERSURNAMETextBox
            // 
            this.uSERSURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "USERSURNAME", true));
            this.uSERSURNAMETextBox.Location = new System.Drawing.Point(87, 191);
            this.uSERSURNAMETextBox.Name = "uSERSURNAMETextBox";
            this.uSERSURNAMETextBox.Size = new System.Drawing.Size(97, 20);
            this.uSERSURNAMETextBox.TabIndex = 37;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(191, 191);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(97, 20);
            this.uSERNAMETextBox.TabIndex = 38;
            // 
            // pATRONYMICTextBox
            // 
            this.pATRONYMICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PATRONYMIC", true));
            this.pATRONYMICTextBox.Location = new System.Drawing.Point(291, 191);
            this.pATRONYMICTextBox.Name = "pATRONYMICTextBox";
            this.pATRONYMICTextBox.Size = new System.Drawing.Size(97, 20);
            this.pATRONYMICTextBox.TabIndex = 39;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(170, 217);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(203, 20);
            this.pHONETextBox.TabIndex = 41;
            // 
            // eMPLOYEESURNAMETextBox
            // 
            this.eMPLOYEESURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewORDERBindingSource, "EMPLOYEESURNAME", true));
            this.eMPLOYEESURNAMETextBox.Location = new System.Drawing.Point(170, 243);
            this.eMPLOYEESURNAMETextBox.Name = "eMPLOYEESURNAMETextBox";
            this.eMPLOYEESURNAMETextBox.Size = new System.Drawing.Size(203, 20);
            this.eMPLOYEESURNAMETextBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "Заказы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.viewORDERBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(416, 25);
            this.ordersBindingNavigator.TabIndex = 47;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // viewORDERBindingSource
            // 
            this.viewORDERBindingSource.DataMember = "ViewORDER";
            this.viewORDERBindingSource.DataSource = this.computer_ShopDataSet;
            // 
            // computer_ShopDataSet
            // 
            this.computer_ShopDataSet.DataSetName = "Computer_ShopDataSet";
            this.computer_ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.computer_ShopDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CatalogsTableAdapter = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazin.Computer_ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // viewORDERTableAdapter
            // 
            this.viewORDERTableAdapter.ClearBeforeFill = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 313);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(pRODUCTSNAMELabel);
            this.Controls.Add(this.pRODUCTSNAMETextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(pRICELabel);
            this.Controls.Add(this.pRICETextBox);
            this.Controls.Add(nUMBERLabel);
            this.Controls.Add(this.nUMBERTextBox);
            this.Controls.Add(oRDERTIMELabel);
            this.Controls.Add(this.oRDERTIMEDateTimePicker);
            this.Controls.Add(uSERSURNAMELabel);
            this.Controls.Add(this.uSERSURNAMETextBox);
            this.Controls.Add(this.uSERNAMETextBox);
            this.Controls.Add(this.pATRONYMICTextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(eMPLOYEESURNAMELabel);
            this.Controls.Add(this.eMPLOYEESURNAMETextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_ShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pRODUCTSNAMETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.TextBox nUMBERTextBox;
        private System.Windows.Forms.DateTimePicker oRDERTIMEDateTimePicker;
        private System.Windows.Forms.TextBox uSERSURNAMETextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pATRONYMICTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox eMPLOYEESURNAMETextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Computer_ShopDataSet computer_ShopDataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource viewORDERBindingSource;
        private Computer_ShopDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Computer_ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Computer_ShopDataSetTableAdapters.ViewORDERTableAdapter viewORDERTableAdapter;
    }
}