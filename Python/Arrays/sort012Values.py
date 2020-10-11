'''
Write a program to sort an array of 0's, 1's and 2's in ascending order.
'''

def sort012Values (inArray: [int]):
    i = 0                   #i stores 0's
    j = 0                   #j stores 1's
    k = len(inArray)-1      #k stores 2's

    while j<=k:
        if inArray[j]==2:
            inArray[j],inArray[k] = inArray[k],inArray[j]
            k-=1
        elif inArray[j]==0:
            inArray[j],inArray[i] = inArray[i],inArray[j]
            i+=1
        else:
            j+=1
    return inArray

print(sort012Values([1,2,0,0,2,0,1,1,2,0,0,1]))