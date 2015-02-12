Module Module1

    Sub Main()
        ' declare pesons
        Dim paul As Person
        Dim margaret As Person

        ' instantiate person1 + give first and last name
        paul = New Person
        paul.fName = "paul"
        paul.lName = "david"

        'instantiate person2 + give first and last name
        margaret = New Person
        margaret.fName = "margaret"
        margaret.lName = "edelman"

        'declare pets
        Dim muffin As Pet
        Dim gretta As Pet
        Dim friskers As Pet

        ' instantiate pets and give the name, age, species and owner
        muffin = New Pet
        muffin.name = "muffin"
        muffin.age = 1
        muffin.species = "cat"
        muffin.owner = paul

        gretta = New Pet
        gretta.name = "gretta"
        gretta.age = 6
        gretta.species = "cat"
        gretta.owner = margaret

        friskers = New Pet
        friskers.name = "friskers"
        friskers.age = 14
        friskers.species = "cat"
        friskers.owner = margaret

        ' print each pets name, age, species and owners full name
        Console.WriteLine("Pet 1 = " & muffin.name & " " & muffin.age & " " & muffin.species & " " & muffin.owner.fullName
                          )
        Console.WriteLine("Pet 2 = " & gretta.name & " " & gretta.age & " " & gretta.species & " " & gretta.owner.fullName
                          )
        Console.WriteLine("Pet 3 = " & friskers.name & " " & friskers.age & " " & friskers.species & " " & friskers.owner.fullName
                          )
        Console.WriteLine("Press any key to exit")
        Console.ReadKey()







    End Sub

End Module
