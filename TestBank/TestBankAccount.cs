using System.Security.Principal;

namespace TestBank
{
    [TestClass]
    public sealed class TestBankAccount
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            //cenário
            double saldo_inicial = 1000;
            double valor_depositado = 500;
            double saldo_esperado = 1500;
            BankAccount conta = new BankAccount("Ana", saldo_inicial);

            //ação
            conta.Credit(valor_depositado);
            double saldo_atual = conta.Balance;

            //verificação
            Assert.AreEqual(saldo_esperado, saldo_atual, 0.001, "Diferença no valor do saldo após depósito");

        }

        [TestMethod]
        public void Deposito_comValorNegativo_LancaArgumentOutOfRangeException()
        {
            //cenário
            double saldo_inicial = 1000;
            double valor_depositado = -500;
            BankAccount conta = new BankAccount("Ana", saldo_inicial);

            //ação e
            //verificação
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => conta.Credit(valor_depositado));
        }
        //teste para saques com valor maior que o saldo

        //Teste para transferência de valores entre contas (TDD)
    }
}
