#...initialize looping variable, assume 'yes' as the first answer
continueYN = "y"

while continueYN == "y":
    #...get temp from user
    sDegreeF = input("Enter next temperature in degrees Farenheight (F):")

    #...convert the users input to an int for math operations
    nDegreeF = int(sDegreeF)

    #...convert from Farenheight to Celcius
    nDegreeC = (nDegreeF - 32) * 5 / 9

    print("Temperature in degrees C is :", nDegreeC)

    #...check for temp below freezing
    if nDegreeC < 0:
        print ("Pack long underwear!")

    #...check for a hot day
    if nDegreeF > 100:
        print ("Don't forget lots of water!")
    
    continueYN = input("Input another?")

# Exit the program