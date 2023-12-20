namespace GSB_FINAL
{
    partial class FMission3
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
            this.dgvfiches = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bsFiches = new System.Windows.Forms.BindingSource(this.components);
            this.aLaSmeneProDataSet = new GSB_FINAL.ALaSmeneProDataSet();
            this.PanelFiltre = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxAnnee = new System.Windows.Forms.ComboBox();
            this.comboBoxMois = new System.Windows.Forms.ComboBox();
            this.checkBoxEtat = new System.Windows.Forms.CheckBox();
            this.checkBoxPeriode = new System.Windows.Forms.CheckBox();
            this.checkBoxMois = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CheckFiltre = new System.Windows.Forms.CheckBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.FiltreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfiches)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLaSmeneProDataSet)).BeginInit();
            this.PanelFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvfiches
            // 
            this.dgvfiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfiches.Location = new System.Drawing.Point(12, 95);
            this.dgvfiches.Name = "dgvfiches";
            this.dgvfiches.Size = new System.Drawing.Size(636, 282);
            this.dgvfiches.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Création";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bsFiches
            // 
            this.bsFiches.DataSource = this.aLaSmeneProDataSet;
            this.bsFiches.Position = 0;
            // 
            // aLaSmeneProDataSet
            // 
            this.aLaSmeneProDataSet.DataSetName = "ALaSmeneProDataSet";
            this.aLaSmeneProDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelFiltre
            // 
            this.PanelFiltre.Controls.Add(this.textBox1);
            this.PanelFiltre.Controls.Add(this.comboBoxAnnee);
            this.PanelFiltre.Controls.Add(this.comboBoxMois);
            this.PanelFiltre.Controls.Add(this.checkBoxEtat);
            this.PanelFiltre.Controls.Add(this.checkBoxPeriode);
            this.PanelFiltre.Controls.Add(this.checkBoxMois);
            this.PanelFiltre.Controls.Add(this.dateTimePickerFin);
            this.PanelFiltre.Controls.Add(this.dateTimePickerDebut);
            this.PanelFiltre.Controls.Add(this.comboBoxEtat);
            this.PanelFiltre.Controls.Add(this.textBox8);
            this.PanelFiltre.Controls.Add(this.textBox7);
            this.PanelFiltre.Controls.Add(this.textBox6);
            this.PanelFiltre.Controls.Add(this.textBox4);
            this.PanelFiltre.Location = new System.Drawing.Point(654, 95);
            this.PanelFiltre.Name = "PanelFiltre";
            this.PanelFiltre.Size = new System.Drawing.Size(300, 177);
            this.PanelFiltre.TabIndex = 7;
            this.PanelFiltre.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(19, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = " /";
            // 
            // comboBoxAnnee
            // 
            this.comboBoxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnnee.FormattingEnabled = true;
            this.comboBoxAnnee.Items.AddRange(new object[] {
            "1523",
            "1524",
            "1525",
            "1526",
            "1527",
            "1528",
            "1529",
            "1530",
            "1531",
            "1532",
            "1533",
            "1534",
            "1535",
            "1536",
            "1537",
            "1538",
            "1539",
            "1540",
            "1541",
            "1542",
            "1543",
            "1544",
            "1545",
            "1546",
            "1547",
            "1548",
            "1549",
            "1550",
            "1551",
            "1552",
            "1553",
            "1554",
            "1555",
            "1556",
            "1557",
            "1558",
            "1559",
            "1560",
            "1561",
            "1562",
            "1563",
            "1564",
            "1565",
            "1566",
            "1567",
            "1568",
            "1569",
            "1570",
            "1571",
            "1572",
            "1573",
            "1574",
            "1575",
            "1576",
            "1577",
            "1578",
            "1579",
            "1580",
            "1581",
            "1582",
            "1583",
            "1584",
            "1585",
            "1586",
            "1587",
            "1588",
            "1589",
            "1590",
            "1591",
            "1592",
            "1593",
            "1594",
            "1595",
            "1596",
            "1597",
            "1598",
            "1599",
            "1600",
            "1601",
            "1602",
            "1603",
            "1604",
            "1605",
            "1606",
            "1607",
            "1608",
            "1609",
            "1610",
            "1611",
            "1612",
            "1613",
            "1614",
            "1615",
            "1616",
            "1617",
            "1618",
            "1619",
            "1620",
            "1621",
            "1622",
            "1623",
            "1624",
            "1625",
            "1626",
            "1627",
            "1628",
            "1629",
            "1630",
            "1631",
            "1632",
            "1633",
            "1634",
            "1635",
            "1636",
            "1637",
            "1638",
            "1639",
            "1640",
            "1641",
            "1642",
            "1643",
            "1644",
            "1645",
            "1646",
            "1647",
            "1648",
            "1649",
            "1650",
            "1651",
            "1652",
            "1653",
            "1654",
            "1655",
            "1656",
            "1657",
            "1658",
            "1659",
            "1660",
            "1661",
            "1662",
            "1663",
            "1664",
            "1665",
            "1666",
            "1667",
            "1668",
            "1669",
            "1670",
            "1671",
            "1672",
            "1673",
            "1674",
            "1675",
            "1676",
            "1677",
            "1678",
            "1679",
            "1680",
            "1681",
            "1682",
            "1683",
            "1684",
            "1685",
            "1686",
            "1687",
            "1688",
            "1689",
            "1690",
            "1691",
            "1692",
            "1693",
            "1694",
            "1695",
            "1696",
            "1697",
            "1698",
            "1699",
            "1700",
            "1701",
            "1702",
            "1703",
            "1704",
            "1705",
            "1706",
            "1707",
            "1708",
            "1709",
            "1710",
            "1711",
            "1712",
            "1713",
            "1714",
            "1715",
            "1716",
            "1717",
            "1718",
            "1719",
            "1720",
            "1721",
            "1722",
            "1723",
            "1724",
            "1725",
            "1726",
            "1727",
            "1728",
            "1729",
            "1730",
            "1731",
            "1732",
            "1733",
            "1734",
            "1735",
            "1736",
            "1737",
            "1738",
            "1739",
            "1740",
            "1741",
            "1742",
            "1743",
            "1744",
            "1745",
            "1746",
            "1747",
            "1748",
            "1749",
            "1750",
            "1751",
            "1752",
            "1753",
            "1754",
            "1755",
            "1756",
            "1757",
            "1758",
            "1759",
            "1760",
            "1761",
            "1762",
            "1763",
            "1764",
            "1765",
            "1766",
            "1767",
            "1768",
            "1769",
            "1770",
            "1771",
            "1772",
            "1773",
            "1774",
            "1775",
            "1776",
            "1777",
            "1778",
            "1779",
            "1780",
            "1781",
            "1782",
            "1783",
            "1784",
            "1785",
            "1786",
            "1787",
            "1788",
            "1789",
            "1790",
            "1791",
            "1792",
            "1793",
            "1794",
            "1795",
            "1796",
            "1797",
            "1798",
            "1799",
            "1800",
            "1801",
            "1802",
            "1803",
            "1804",
            "1805",
            "1806",
            "1807",
            "1808",
            "1809",
            "1810",
            "1811",
            "1812",
            "1813",
            "1814",
            "1815",
            "1816",
            "1817",
            "1818",
            "1819",
            "1820",
            "1821",
            "1822",
            "1823",
            "1824",
            "1825",
            "1826",
            "1827",
            "1828",
            "1829",
            "1830",
            "1831",
            "1832",
            "1833",
            "1834",
            "1835",
            "1836",
            "1837",
            "1838",
            "1839",
            "1840",
            "1841",
            "1842",
            "1843",
            "1844",
            "1845",
            "1846",
            "1847",
            "1848",
            "1849",
            "1850",
            "1851",
            "1852",
            "1853",
            "1854",
            "1855",
            "1856",
            "1857",
            "1858",
            "1859",
            "1860",
            "1861",
            "1862",
            "1863",
            "1864",
            "1865",
            "1866",
            "1867",
            "1868",
            "1869",
            "1870",
            "1871",
            "1872",
            "1873",
            "1874",
            "1875",
            "1876",
            "1877",
            "1878",
            "1879",
            "1880",
            "1881",
            "1882",
            "1883",
            "1884",
            "1885",
            "1886",
            "1887",
            "1888",
            "1889",
            "1890",
            "1891",
            "1892",
            "1893",
            "1894",
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAnnee.Location = new System.Drawing.Point(236, 24);
            this.comboBoxAnnee.Name = "comboBoxAnnee";
            this.comboBoxAnnee.Size = new System.Drawing.Size(56, 21);
            this.comboBoxAnnee.TabIndex = 15;
            // 
            // comboBoxMois
            // 
            this.comboBoxMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMois.FormattingEnabled = true;
            this.comboBoxMois.Items.AddRange(new object[] {
            "JANVIER",
            "FÉVRIER",
            "MARS",
            "AVRIL",
            "MAI",
            "JUIN",
            "JUILLET",
            "AOUT",
            "SEPTEMBRE",
            "OCTOBRE",
            "NOVEMBRE",
            "DÉCEMBRE"});
            this.comboBoxMois.Location = new System.Drawing.Point(135, 23);
            this.comboBoxMois.Name = "comboBoxMois";
            this.comboBoxMois.Size = new System.Drawing.Size(68, 21);
            this.comboBoxMois.TabIndex = 14;
            // 
            // checkBoxEtat
            // 
            this.checkBoxEtat.AutoSize = true;
            this.checkBoxEtat.Location = new System.Drawing.Point(8, 103);
            this.checkBoxEtat.Name = "checkBoxEtat";
            this.checkBoxEtat.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEtat.TabIndex = 13;
            this.checkBoxEtat.UseVisualStyleBackColor = true;
            this.checkBoxEtat.CheckedChanged += new System.EventHandler(this.checkBoxEtat_CheckedChanged);
            // 
            // checkBoxPeriode
            // 
            this.checkBoxPeriode.AutoSize = true;
            this.checkBoxPeriode.Location = new System.Drawing.Point(8, 68);
            this.checkBoxPeriode.Name = "checkBoxPeriode";
            this.checkBoxPeriode.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPeriode.TabIndex = 12;
            this.checkBoxPeriode.UseVisualStyleBackColor = true;
            this.checkBoxPeriode.CheckedChanged += new System.EventHandler(this.checkBoxPeriode_CheckedChanged);
            // 
            // checkBoxMois
            // 
            this.checkBoxMois.AutoSize = true;
            this.checkBoxMois.Location = new System.Drawing.Point(8, 27);
            this.checkBoxMois.Name = "checkBoxMois";
            this.checkBoxMois.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMois.TabIndex = 9;
            this.checkBoxMois.UseVisualStyleBackColor = true;
            this.checkBoxMois.CheckedChanged += new System.EventHandler(this.checkBoxMois_CheckedChanged);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(214, 65);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(78, 20);
            this.dateTimePickerFin.TabIndex = 11;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(99, 65);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerDebut.TabIndex = 10;
            this.dateTimePickerDebut.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Items.AddRange(new object[] {
            "Remboursée",
            "Saisie clôturée",
            "Fiche créée, saisie en cours",
            "Validée et mise en paiement"});
            this.comboBoxEtat.Location = new System.Drawing.Point(135, 100);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEtat.TabIndex = 7;
            this.comboBoxEtat.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(29, 101);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 6;
            this.textBox8.Text = "État :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(29, 65);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(63, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Période :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Mois/Année :";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(189, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(19, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = " /";
            // 
            // CheckFiltre
            // 
            this.CheckFiltre.AutoSize = true;
            this.CheckFiltre.Location = new System.Drawing.Point(654, 72);
            this.CheckFiltre.Name = "CheckFiltre";
            this.CheckFiltre.Size = new System.Drawing.Size(66, 17);
            this.CheckFiltre.TabIndex = 8;
            this.CheckFiltre.Text = "FILTRE ";
            this.CheckFiltre.UseVisualStyleBackColor = true;
            this.CheckFiltre.CheckedChanged += new System.EventHandler(this.CheckFiltre_CheckedChanged);
            // 
            // FiltreButton
            // 
            this.FiltreButton.Location = new System.Drawing.Point(358, 497);
            this.FiltreButton.Name = "FiltreButton";
            this.FiltreButton.Size = new System.Drawing.Size(75, 23);
            this.FiltreButton.TabIndex = 9;
            this.FiltreButton.Text = "Filtres";
            this.FiltreButton.UseVisualStyleBackColor = true;
            this.FiltreButton.Click += new System.EventHandler(this.FiltreButton_Click);
            // 
            // FMission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.FiltreButton);
            this.Controls.Add(this.CheckFiltre);
            this.Controls.Add(this.PanelFiltre);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvfiches);
            this.Name = "FMission3";
            this.Text = "FMission3";
            this.Load += new System.EventHandler(this.FMission3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfiches)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLaSmeneProDataSet)).EndInit();
            this.PanelFiltre.ResumeLayout(false);
            this.PanelFiltre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfiches;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bsFiches;
        private ALaSmeneProDataSet aLaSmeneProDataSet;
        private System.Windows.Forms.Panel PanelFiltre;
        private System.Windows.Forms.CheckBox CheckFiltre;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.CheckBox checkBoxEtat;
        private System.Windows.Forms.CheckBox checkBoxPeriode;
        private System.Windows.Forms.CheckBox checkBoxMois;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxAnnee;
        private System.Windows.Forms.ComboBox comboBoxMois;
        private System.Windows.Forms.Button FiltreButton;
    }
}