# Our_Body

<div dir='rtl' lang='he'>
<br />
<br />
  
![picture2](https://user-images.githubusercontent.com/57682267/102871135-b8936900-4446-11eb-89b6-2d9335149039.jpg)
  
 <br /> 
  
במטלה זו אנחנו מציגות  כמה שניות מהמשחק הסופי שלנו <br />
במשחק יש לנו: <br />
שחקן <br /> 
חיידקים טובים <br />
חיידקים רעים <br />
קיר העברת שלב <br />
כמות חיים <br />
וסופר נקודות <br />

המטרה של השחקן היא לרפא את הגוף,<br />
להיזהר לא להפגע מהחיידקים הרעים<br />
ולאסוף כמה שיותר חיידקיים טובים על מנת לעבור לשלב הבא.<br />
<br />
במטלה זו הראנו שלב התחלתי<br />
להכרות עם המשחק<br />

השחקן זז בעזרת מקדי המקדלת<br />
הוא יכול להסתכל לצדדים ע"י הזזת עכבר.<br />

[השחקן זז ע"י הקוד הבא:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/1-player/CharacterKeyboardMover.cs) <br />

קוד זה נמצא על רכיב שנמצא על השחקן<br />

[השחקן מסתכל לצדדים ע"י הקוד הבא:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/1-player/LookX.cs) <br />
 
 
בנוסף יש על השחקן קוד האחראי על התנגשויות: <br />
במידה והשחקן נפגש בחיידק טוב,<br />
כמות הנקודות שלו עולה.<br />
במידה ופוגע בחיידק רע כמות החיים שלו יורדת.<br />
כאשר נגמר לשחקן החיים הוא מתחיל את השלב מחדש.<br />

[ניתן לראות ע"י הקוד הבא:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/5-bacterias/OnTriggerPlayer.cs) <br />

בנוסף על השחקן הקוד האחראי על העכבר שלא יצא מגבולות המשחק עד שנסמן אחרת.<br />
[ניתן לראות ע"י הקוד הבא מהשיעור:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/1-player/CursorHider.cs) <br />

הקוד האחראי על העברת שלב:<br />
[ניתן לראות ע"י הקוד הבא:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/3-objects/NextLevel.cs) <br />

על החיידקים הרעים ישנו קוד האחראי על תזוזתם<br />
החיידיקם מתקרבים לשחקן<br /> 

[ניתן לראות ע"י הקוד הבא:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/5-bacterias/mover_oscillator.cs) <br />

בנוסף במשחק יש 2 רכיבי טקסט:<br />
אחד האחראי על הסבר המשחק<br />
והשני אחראי על הצגת נקודות השחקן<br />

[ הסבר המשחק:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/4-Text/ShowText.cs) <br />

טקסט הצגת הנקודות מתעדכן דרך הקוד של התנגשויות<br />
ברגע שיש התנגשות בחיידק טוב,<br />
נעלה את כמות הנקודות<br />
ונעדכן את הטקסט<br />

[ניתן לראות ע"י הקוד הבא:](https://github.com/ComputerGame0/Our_Body_30Sec/blob/main/Assets/Scripts/5-bacterias/OnTriggerPlayer.cs) <br />



