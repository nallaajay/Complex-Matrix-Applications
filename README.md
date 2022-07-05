
**Objective of the assignment is to use the complex number class that can create and perform mathematical operations on complex numbers for any given size of matrix, and create a structure of code base to show some applications**

* **Name** : **Nalla Ajay**

----

#### Dependencies : 

1. Visual Studio 
2. .NET Core 3.1 framework
3. Windows  x64 bit OS.

---

#### Description :

* When the  assignment_8.exe runs, it compiles and exits with a zero. This code base is a structure for some applications of complex number class and does not contain any working code. The complex number is however fully built with capabilities of performing complex matrix mathematical operations.


---

#### Classes and Methods:

1. complex_number class contains constructors for creating complex number types. This also contains methods for overloading operators * for multiplying two complex number types and for overloading operator +,-,/ for adding ,subtracting & dividing two complex number types. Also contains a string override method.
2. complex_matrix class contains constructor for creating complex matrices and operator overloading * for multiplying two complex number matrices, operator overloading / for dividing two complex matrices ,method for vector multiplication and method for printing the output of multiplication operation.
3. solution_class contains the main method. 
4. transfer_functions: This contains various methods to create transfer functions of machines, electrical system and controller.
5. tf_openloop: This inherits the transfer_functions class and contains methods to create open loop transfer function of system in s-domain.
6. tf_closedloop: This inherits the tf_openloop class and contains methods to create closed loop transfer function of the system in s-domain.
7. tf_s_to_z: This inherits transfer_functions class; This contains methods to create open loop and closed loop transfer functions of the system in z-domain.
8. stability_analysis: This inherits the tf_openloop class; Contains methods for finding nyquist plot, FRF(bode plot) of system. Also has methods to find phase and gain marigins from bode and stability margins from nyquist.
9. State_space_model: Inherits tf_closedloop class; contains methods to find state equation and output equation from the state vector and input vector.
10. discrete_state_space: Inherits state_space_model; contains method to override state_equation method to find the future state of system based on the past state. The output equation is same as the state space model.
11. encryption: Contains methods to get variables from complex number class,collect user input as key, create encryption matrix, and string override method.
12. decryption: Inherits encryption class; contains methods to create decryption matrix and print decrypted message.

------

#### Compilation Instructions: 

Published using Visual studio, Configuration: Release | Any cpu ; Target framework: netcoreapp3.1; Deployment mode: Framework-dependent; Target runtime: win-x64; Enables ReadyToRun compilation.

**The zip file contains app.zip which contains all the necessary dll's and execuatble; source.zip contains the  source code.**

#### Author: Nalla Ajay
