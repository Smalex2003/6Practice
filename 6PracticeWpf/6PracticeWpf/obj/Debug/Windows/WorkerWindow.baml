   M S B A M L   `   `   `  ????G  C6PracticeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:_6PracticeWpf_6PracticeWpf  5   	        _6PracticeWpf.WorkerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:_6PracticeWpf     5   	     ? Icon$?  9C:\6Practice\6PracticeWpf\6PracticeWpf\Resources\Logo.jpg??5   	    ? Title$* $Окно с сотрудниками??6J   $	??450??6f   $	??800??6s   $	??200??6   $	??600??6?   $
??1000??6?   
???????.??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??1* ?6   6*   ?? 5      $??5* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ GridWorkers??5      $??2??6(      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6c   $??Comic Sans MS)?6s      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Код работника??6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   ?? *Id+  5      $ Фамилия??6%   	 66   ?? *	Surname+  5      $ Имя??6%   	 62   ?? *Name+  5      $ Отчество??6%   	 67   ?? *
MiddleName+  5      $ Пол??6%   	 62   ?? *Gender+  5      $) #Семейное положение??6%   	 6A   ?? *MaritalStatus+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      ?? 5      .R?5      ??  ??Name$ BtnEditWorker??6%   -   5        
???????$ ??Редактировать??5   T   6?   5      5      5      ?? 5   
   -   5        $??AddworkerBtn??5   )   
???????$??Comic Sans MS)?6=   $+??%Добавить сотрудника??6X   $
??Left=?6v   $??	607,0,0,0q?6?   $??Center=?6?   $??34??6?   $	??165??6?   $??14(?6?   6?   ?? 5    
   $??16(?6   $??Comic Sans MS)?6   $_??YЗдесь вы можете посмотреть сотрудников компании??69   $
??Left=?6s   $??10,0,0,0q?6?   $??Center=?6?   5!      5"      