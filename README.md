# Accounting System

#### Step:1
![image](https://github.com/user-attachments/assets/95baf45d-8f4d-4f0c-9a67-bc6682a65e5f)

MS SQL Database Script

```
-- Currency Table
CREATE TABLE Currency (
    CurrencyID INT IDENTITY(1,1) PRIMARY KEY,
    CurrencyCode VARCHAR(3) UNIQUE NOT NULL DEFAULT 'CHF',
    ExchangeRate DECIMAL(18,6) NOT NULL CHECK (ExchangeRate > 0),
    UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);
-- Chart of Accounts Table
CREATE TABLE ChartOfAccounts (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    AccountNumber VARCHAR(50) UNIQUE NOT NULL,
    AccountName NVARCHAR(255) NOT NULL,
    AccountType VARCHAR(50) CHECK (AccountType IN ('Asset', 'Liability', 'Equity', 'Revenue', 'Expense')),
    AccountGroup NVARCHAR(255),
    OpeningBalance DECIMAL(18,2) DEFAULT 0,
	CurrencyID INT NOT NULL,
	IsActive BIT DEFAULT 1,
	FOREIGN KEY (CurrencyID) REFERENCES Currency(CurrencyID)
);


-- VAT Tax Table
CREATE TABLE VATTaxes (
    VATID INT IDENTITY(1,1) PRIMARY KEY,
    VATRate DECIMAL(5,2) NOT NULL CHECK (VATRate >= 0),
    EffectiveDate DATE NOT NULL
);

CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionDate DATE NOT NULL,
    TransactionNumber VARCHAR(50) UNIQUE NOT NULL,
    Description NVARCHAR(500),
    Reference NVARCHAR(255),
    DebitAccountID INT NOT NULL,
    CreditAccountID INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    VATID INT NULL,
    VATAmount DECIMAL(18,2) DEFAULT 0,
    CurrencyID INT NOT NULL,
    FOREIGN KEY (DebitAccountID) REFERENCES ChartOfAccounts(AccountID),
    FOREIGN KEY (CreditAccountID) REFERENCES ChartOfAccounts(AccountID),
    FOREIGN KEY (VATID) REFERENCES VATTaxes(VATID),
    FOREIGN KEY (CurrencyID) REFERENCES Currency(CurrencyID)
);
```
#### Step:2
Widows Form Application with .NET 8, N-Tier Architecture, and the Repository Pattern

#### Step:3
Dapper ORM,Serilog for logging.
