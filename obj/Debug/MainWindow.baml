   M S B A M L   `   `   `  ????G  CWriteUrSpend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WriteUrSpendWriteUrSpend  5   	       WriteUrSpend.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WriteUrSpend     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? $??185,100,263,100q?6   .+?5      ?? 
???  ??$	??200??6)   $	??200??69   $.??(Ваши покупки сегодня: ??6H   $??45??6f   $	??140??6r   ?? 5      -   5         ??Name$ NameBuy??5      
???  ??$#??ОПИШИТЕ ПОКУПКУ??69   $	??148??6P   ?? 5      -   5         ??Name$ NameCategory??5      $??5q?6-   
???  ??$	??172??6K   $??20??6W   5      ?? 5      -   5        $ TypePayment??5      $??5q?6,    ?? Text$ TypePayment??67   
???  ??$	??173??6\   5      ?? 5      -   5        $	 Sum??5      $??5q?6#   $	??Sum??6.   
???  ??$	??173??6K   ?? 5      -   5        $??SaveOperation??5      $??Сохранить??6F   6\   ?? 5      -   5        $??GotoIncomePage??5      $??
говно??6+   $??5q?6;   6e   5      ?? 5   
   $??247,45,342,347q?6   ?? 5   
   $	??200??6   $	??250??6!   $??542,92,58,92q?6.   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $??Баланс карты??6   $??76??60   ?? 5      -   5         ??Name$ BalanceCard??5   6   $(??"Баланс карты число??6   $	??116??6K   5      ?? 5      $ 
Horizontal=?6   .+?5      ?? $#??Баланс наличные??6   $	??105??63   ?? 5       -	   5        $ BalanceCash??5    *   $?? число??6   $??90??6@   5!      5#      ?? 5$   
   $	??300??6   $
??Left=?6$   $	??Top=?6?   $??75??6W   .+?5%      ?? ??6   ?? *	DateToday+ ?? RelativeSource ?? *FindAncestor+ ?? AncestorType" ?5&      ]? 5'   
   $	??180??6   $
??Left=?6    $	??300??6;   .+?5(       ? -
   5          ?Name$ NavigationFrame??5(      	  ? NavigationUIVisibility$	 Hidden=?6.   $
??Left=?6N   6k   5)      5,      5-      