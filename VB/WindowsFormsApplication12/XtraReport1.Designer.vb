Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication12
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New WindowsFormsApplication12.nwindDataSet()
			Me.categoriesTableAdapter = New WindowsFormsApplication12.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.AggregateField = New DevExpress.XtraReports.UI.CalculatedField()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.productsTableAdapter = New WindowsFormsApplication12.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.UnitTotal = New DevExpress.XtraReports.UI.CalculatedField()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 148.9583F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.White
			Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic)
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.999998F, 82.04168F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(645.6248F, 52.83334F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UsePadding = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "* The number of entries in this category that are not discontinued and have their" & " total unit value greater than $500 (in the following report, such entries are h" & "ighlighted with red)."
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(645.6249F, 31.33334F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UsePadding = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998F, 51.74999F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(645.6248F, 30.29168F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UsePadding = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Aggregated value* for this category: [AggregateField]"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 50F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 47.91667F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' AggregateField
			' 
			Me.AggregateField.DataMember = "Categories"
			Me.AggregateField.Expression = "[CategoriesProducts][NOT[Discontinued]AND[UnitTotal] >= 500].Count()"
			Me.AggregateField.Name = "AggregateField"
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader})
			Me.DetailReport.DataAdapter = Me.productsTableAdapter
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.nwindDataSet1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail1.HeightF = 34.375F
			Me.Detail1.Name = "Detail1"
			' 
			' xrTable1
			' 
			Me.xrTable1.BorderColor = System.Drawing.Color.Gainsboro
			Me.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTable1.ForeColor = System.Drawing.Color.DimGray
			Me.xrTable1.FormattingRules.Add(Me.formattingRule1)
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(645.6249F, 28.125F)
			Me.xrTable1.StylePriority.UseBorderColor = False
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UseForeColor = False
			Me.xrTable1.StylePriority.UsePadding = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' formattingRule1
			' 
			Me.formattingRule1.Condition = "NOT[Discontinued]AND[UnitTotal] >= 500"
			Me.formattingRule1.DataMember = "Categories.CategoriesProducts"
			' 
			' 
			' 
			Me.formattingRule1.Formatting.BackColor = System.Drawing.Color.Transparent
			Me.formattingRule1.Formatting.ForeColor = System.Drawing.Color.Red
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell4, Me.xrTableCell10, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 1R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.StylePriority.UseTextAlignment = False
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell2.Weight = 0.43707665940720475R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:$0.00}")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell4.Weight = 0.54840224244485136R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitTotal", "{0:$0.00}")})
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.StylePriority.UseTextAlignment = False
			Me.xrTableCell10.Text = "xrTableCell10"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell10.Weight = 0.51452109814794389R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.Discontinued")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.StylePriority.UseTextAlignment = False
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell3.Weight = 0.5R
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.ReportHeader.HeightF = 36.45833F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrTable2
			' 
			Me.xrTable2.BackColor = System.Drawing.Color.Transparent
			Me.xrTable2.BorderColor = System.Drawing.Color.Gainsboro
			Me.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTable2.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(645.6249F, 28.125F)
			Me.xrTable2.StylePriority.UseBackColor = False
			Me.xrTable2.StylePriority.UseBorderColor = False
			Me.xrTable2.StylePriority.UseBorders = False
			Me.xrTable2.StylePriority.UseFont = False
			Me.xrTable2.StylePriority.UsePadding = False
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell9, Me.xrTableCell8})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "Product Name"
			Me.xrTableCell5.Weight = 1R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "Units in Stock"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell6.Weight = 0.43707651760237531R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.StylePriority.UseTextAlignment = False
			Me.xrTableCell7.Text = "Unit Price"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell7.Weight = 0.54840266785933978R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.StylePriority.UseTextAlignment = False
			Me.xrTableCell9.Text = "Total Unit Value"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell9.Weight = 0.5145208145382848R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.StylePriority.UseTextAlignment = False
			Me.xrTableCell8.Text = "Discontinued"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell8.Weight = 0.5R
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' UnitTotal
			' 
			Me.UnitTotal.DataMember = "Categories.CategoriesProducts"
			Me.UnitTotal.Expression = "[UnitsInStock] * [UnitPrice]"
			Me.UnitTotal.Name = "UnitTotal"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.AggregateField, Me.UnitTotal})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.Font = New System.Drawing.Font("Times New Roman", 9.75F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)))
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
			Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 48)
			Me.Version = "12.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private AggregateField As DevExpress.XtraReports.UI.CalculatedField
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private UnitTotal As DevExpress.XtraReports.UI.CalculatedField
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
	End Class
End Namespace
