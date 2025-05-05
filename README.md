# 🕹️ Jogo da Velha com .NET MAUI

Este é um simples jogo da velha (tic-tac-toe) desenvolvido na tecnologia **.NET MAUI**, como parte do curso de Desenvolvimento de Apps com .NET MAUI.

![.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/media/maui.png)

## 🔧 Tecnologias utilizadas

- .NET MAUI
- C#
- XAML

## 🎮 Funcionalidades

- Interface estilizada com fundo degradê e botões personalizados
- Lógica de alternância entre os jogadores X e O
- Verificação de vitória para a primeira linha (parcial)
- Reinício do jogo automaticamente após vitória

## 🧠 Lógica principal

```csharp
if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
{
    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
    Zerar();
}
