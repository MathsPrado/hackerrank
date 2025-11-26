# 🏛️ Roman to Integer Converter

An implementation that solves the problem of converting a valid Roman numeral string into its corresponding integer value.

---

## 📜 Problem Description

Roman numerals are represented by seven different symbols: `I`, `V`, `X`, `L`, `C`, `D`, and `M`.

| Symbol | Value |
| :------ | :---- |
| `I`     | 1     |
| `V`     | 5     |
| `X`     | 10    |
| `L`     | 50    |
| `C`     | 100   |
| `D`     | 500   |
| `M`     | 1000  |

Roman numerals are usually written largest to smallest from left to right. However, there are six instances where **subtraction** is used to represent a value:

1.  **`I`** can be placed before **`V`** (5) and **`X`** (10) to make **4** (`IV`) and **9** (`IX`).
2.  **`X`** can be placed before **`L`** (50) and **`C`** (100) to make **40** (`XL`) and **90** (`XC`).
3.  **`C`** can be placed before **`D`** (500) and **`M`** (1000) to make **400** (`CD`) and **900** (`CM`).

Given a Roman numeral string, the goal is to convert it to an integer.

---

## ✨ Examples

| Input (`s`) | Output (Integer) | Explanation |
| :------------ | :-------------- | :--------- |
| `"III"`         | `3`             | 3 = 1 + 1 + 1. |
| `"LVIII"`       | `58`            | L = 50, V = 5, III = 3. |
| `"MCMXCIV"`     | `1994`          | M = 1000, CM = 900, XC = 90, IV = 4. |

---

## ⚙️ Constraints

* `1 <= s.length <= 15`
* `s` contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
* It is **guaranteed** that `s` is a valid Roman numeral in the range `[1, 3999]`.

---

## 💡 Solution Approach

The solution involves traversing the Roman numeral string (e.g., from **right to left** or **left to right**) and calculating the running total, with special handling for the six subtractive cases.

### Right-to-Left Strategy

1.  Create a map (or dictionary) to store the integer value of each Roman symbol.
2.  Initialize the total sum with the value of the **last** symbol in the string.
3.  Iterate through the rest of the string from **right to left** (or from the second-to-last character backward).
4.  For each current symbol:
    * If the current symbol's value is **less than** the value of the symbol immediately to its right (the symbol already processed), it signifies a subtractive pair (e.g., `I` before `V` in `IV`). **Subtract** the current symbol's value from the total sum.
    * Otherwise, **add** the current symbol's value to the total sum.

This approach ensures that subtractive pairs are correctly interpreted in a single pass.

---

## 🛠️ Installation and Usage

*(This section should be tailored based on your programming language and project structure.)*

### Prerequisites

* [Mention the required language/runtime, e.g., `Python 3`, `Java JDK`, `Go 1.20+`, etc.]

### Cloning the Repository

```bash
git clone [https://github.com/your-username/repo-name.git](https://github.com/your-username/repo-name.git)
cd repo-name