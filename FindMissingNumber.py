#Find the missing number in an array
#Given a list of numbers unsorted, find the missing number where n is the length
#of the array and all numbers are consecutive
#example arr=[1,4,5,2] result=3

def findMissingNum(arr):
    arr.sort()
    if arr[0] != 1:
        print("1")
    else:
        n=len(arr)
        for i in range(1,n-1):
            if i+1 != arr[i]:
                print(i+1)
                return
        print(n+1)

def findMissingNum_Opt(arr):
    n=len(arr)
    suma=0
    for i in range(0,n):
        suma+=arr[i]   
    tot=((n+1)*((n+1)+1))/2
    miss_num=int(tot-suma)
    print(miss_num)

arr=[5,4,3,2]    
findMissingNum_Opt(arr)