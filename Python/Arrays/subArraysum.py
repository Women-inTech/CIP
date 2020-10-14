#Given an unsorted array of non-negative integers, find a continuos subarray which adds
#to a given number
#Example: Input: arr={1,4,20,3,10,5} , sum=33  
#        Output: Sum found between indexes 2 and 4

def subArraySum(sum,arr):
    val=arr[0]
    j=0
    k= len(arr)
    i=1
    while i < k:
        if val == sum:
            print("Sum found between indexes " + str(j) + " and " + str(i-1))
            return
        elif val < sum:
            val += arr[i]
            i += 1                  
        elif val > sum:
            val -= arr[j]
            j += 1
                        
    print("nothing")

# arr=[1,4,20,3,10,5]
#sum=33
arr=[1,4,0,0,3,10,5]
sum=7
subArraySum(sum,arr)