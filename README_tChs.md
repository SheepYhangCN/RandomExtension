# 如何使用
把 ```using SheepYhangCN.RandomExtension;``` 添加到你C#檔案的開頭

# References
```<Random實例>.Choose<T>(value1,value2,value3...)``` => 隨機選擇value<br>
```<Random實例>.FiftyFifty()``` => true/false<br>
```<Random實例>.FiftyFifty<T>(value1,value2)``` => 50%概率返回value1，50%概率返回value2<br>
```<Random實例>.Chance(概率)``` => 你輸入的概率返回true，否則返回false<br>
```<Random實例>.Chance(被除数,除数)``` => 你輸入的概率返回true，否則返回false<br>
```<Random實例>.Chance<T>(概率,value1,value2,value3...)``` => 你輸入的概率返回value1，否則從[value2,value3...]中隨機返回一個<br>
```<Random實例>.ChancePerItem<T>({[value1,概率],[value2,概率]...})``` => 從你輸入的概率來返回值