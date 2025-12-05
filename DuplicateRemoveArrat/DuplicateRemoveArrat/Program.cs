// See https://aka.ms/new-console-template for more information
using DuplicateRemoveArrat;


//Ia feita para realizar testes personalizados no método RemoveDuplicatesFromArray da classe RemoveDuplicates, pois em 
//leetcode so usa a funcao criada em RemoeDuplicates para resoluçao do problema..

Console.WriteLine("--- Teste da Solução RemoveDuplicates (LINQ) ---");

// Instancia a classe Solution para acessar o método
RemoveDuplicates solver = new RemoveDuplicates();

// Dados de Teste (Exemplo 2)
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int[] expectedNums = { 0, 1, 2, 3, 4 }; // Os 5 elementos únicos esperados

Console.WriteLine($"\nEntrada Original: [{string.Join(", ", nums)}]");

// Chama a sua implementação
int k = solver.RemoveDuplicatesFromArray(nums);

// --- Verificações do Juiz Personalizado ---

// 1. Assert: k == expectedNums.Length
bool lengthAssertion = k == expectedNums.Length;
Console.WriteLine($"\n✅ k retornado ({k}) == Comprimento Esperado ({expectedNums.Length})? -> {(lengthAssertion ? "Sucesso" : "FALHA")}");

// 2. Assert: nums[i] == expectedNums[i] para i < k
bool elementsAssertion = true;
for (int i = 0; i < k; i++)
{
    if (nums[i] != expectedNums[i])
    {
        elementsAssertion = false;
        break;
    }
}
Console.WriteLine($"✅ Primeiros k elementos estão corretos? -> {(elementsAssertion ? "Sucesso" : "FALHA")}");

// Resultado Final
if (lengthAssertion && elementsAssertion)
{
    Console.WriteLine("\n🎉 Resultado Final: Solução ACEITA!");
}
else
{
    Console.WriteLine("\n❌ Resultado Final: Solução REJEITADA!");
}

Console.WriteLine($"\nArray 'nums' após a modificação (apenas k elementos são relevantes):");
// Mostra apenas os k elementos relevantes, como o juiz verificaria
Console.WriteLine($"[{string.Join(", ", nums.Take(k))}]");
Console.WriteLine($"(Os elementos restantes são ignorados e podem ser qualquer valor.)");