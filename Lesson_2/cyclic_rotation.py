"""


An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).

The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

Write a function:

    def solution(A, K)

that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given
    A = [3, 8, 9, 7, 6]
    K = 3

the function should return [9, 7, 6, 3, 8]. Three rotations were made:
    [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
    [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
    [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]

For another example, given
    A = [0, 0, 0]
    K = 1

the function should return [0, 0, 0]

Given
    A = [1, 2, 3, 4]
    K = 4

the function should return [1, 2, 3, 4]

Assume that:

        N and K are integers within the range [0..100];
        each element of array A is an integer within the range [−1,000..1,000].

In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

"""

# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")


def solution(A, K):
    # write your code in Python 3.6
    if A == []:
        # retorna uma lista vazia
        # necessário para passar em um dos testes
        return A
    else:
        lista = A
        # rotacionando por K vezes
        for i in range(K):
            # recebe o ultimo valor de A na primeira posição
            # e recebe a partir da segunda posição os demais valores de A 
            lista[0], lista[1:] = A[-1], A[:-1]
            # A recebe a lista rotacionada
            A = lista
        return lista
