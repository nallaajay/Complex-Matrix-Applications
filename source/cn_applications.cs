///  Mech 540-A  :  Assignment-8; Applications of complex_number_class
///
///  Name        :  Ajay Nalla
///  Student ID  :  49640014
///  Source file :  cn_applications.cs
///  Purpose     :  To create a basic structure for a code base that demonstrates the applications of complex_number_class
///                 Uses complex_number_class; Conatains namespaces: control_systems, state_space_model, cryptography
///  Description :  Contains classes 
///                 1)transfer_functions: This contains various methods to create transfer functions of machines, 
///                   electrical system and controller
///                 2)tf_openloop: This inherits the transfer_functions class and contains methods to create open loop 
///                   transfer function of system in s-domain.
///                 3)tf_closedloop: This inherits the tf_openloop class and contains methods to create closed loop
///                   transfer function of the system in s-domain.
///                 4)tf_s_to_z: This inherits transfer_functions class; This contains methods to create open loop
///                   and closed loop transfer functions of the system in z-domain.
///                 5)stability_analysis: This inherits the tf_openloop class; Contains methods for finding nyquist plot, 
///                   FRF(bode plot) of system. Also has methods to find phase and gain marigins from bode and stability
///                   margins from nyquist.
///                 6)State_space_model: Inherits tf_closedloop class; contains methods to find state equation and output 
///                   equation from the state vector and input vector.
///                 7)discrete_state_space: Inherits state_space_model; contains method to override state_equation method
///                   to find the future state of system based on the past state. The output equation is same as the state
///                   space model.
///                 8)encryption: Contains methods to get variables from complex number class,collect user input as key,
///                   create encryption matrix, and string override method.
///                 9)decryption: Inherits encryption class; contains methods to create decryption matrix and print
///                   decrypted message.   
///                   
/// ************************* USINGS *************************
using System;
using complex_number_class;
namespace control_systems
{
    /// ************************* CLASSES *************************
    /// Class       : transfer_functions
    /// Description : Contains methods for creating transfer function of machine,controler and electrical.
    class transfer_functions
    {
        /// ************************* METHOD *************************
        /// Method    : transfer_functions
        /// Arguments : None
        /// Returns   : Nothing
        /// This is a constructor method, it creates transfer function objects.
        public transfer_functions ()
        {
            //Constructor to create transfer function type objects
        }
        /// ************************* METHOD *************************
        /// Method    : tf_machine
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates transfer function of machine.
        public virtual void tf_machine()
        {
            //Method to create tf of machine
        }
        /// ************************* METHOD *************************
        /// Method    : tf_controller
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates transfer function of controller.
        public virtual void tf_controller()
        {
            //Method to create tf of controller
        }
        /// ************************* METHOD *************************
        /// Method    : tf_electrical
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates transfer function of electrical.
        public void tf_electrical()
        {
            //Method to create tf of electrical
        }
        /// ************************* METHOD *************************
        /// Method    : feed_back
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates feed back loop.
        public void feed_back()
        {
            //Method to create feedback loop.
        }
    }
    /// ************************* CLASSES *************************
    /// Class       : tf_openloop
    /// Description : Contains methods for creating open loop transfer function of system in s-domain.
    ///               Inherits transfer_functions class
    class tf_openloop :transfer_functions
    {
        /// ************************* METHOD *************************
        /// Method    : override tf_machine
        /// Arguments : None
        /// Returns   : Nothing
        /// This method overrides the method from transfer function class.
        public override void tf_machine()
        {
            //If there are any forces or disturbances neglected for easier calculations in open
            //loop tf, this method is used to create new tf of machine.
            base.tf_machine();
        }
        /// ************************* METHOD *************************
        /// Method    : tf_openloop
        /// Arguments : None
        /// Returns   : Nothing
        /// This constructor method creates obejects of open loop transfer functions.
        public tf_openloop()
        {
            //Creates a open loop tf from tf of machine, controller and electrical.
            tf_machine();
            tf_controller();
            tf_electrical();
        } 
    }
    /// ************************* CLASSES *************************
    /// Class       : tf_closedloop
    /// Description : Contains methods for creating closed loop transfer function of system in s-domain
    ///               Inherits transfer_functions class
    class tf_closedloop :tf_openloop
    {
        /// ************************* METHOD *************************
        /// Method    : override tf_controller
        /// Arguments : None
        /// Returns   : Nothing
        /// This method overrides the method from transfer function class.
        public override void tf_controller()
        {   //If there are any forces or disturbances neglected for easier calculations in closed
            //loop tf, this method is used to create new tf of controller.
            base.tf_controller();
        }
        /// ************************* METHOD *************************
        /// Method    : tf_closedloop
        /// Arguments : None
        /// Returns   : Nothing
        /// This constructor method creates obejects of closed loop transfer functions.
        public tf_closedloop()
        {
            //Creates a open loop tf from tf of machine, controller, electrical and feedback
            tf_machine();
            tf_controller();
            tf_electrical();
            feed_back();
        }
    }
    /// ************************* CLASSES *************************
    /// Class       : tf_s_to_z
    /// Description : Contains methods for creating open loop and closed loop transfer function of system in z-domain.
    ///               Inherits transfer_functions class
    class tf_s_to_z :transfer_functions
    {
        /// ************************* METHOD *************************
        /// Method    : tf_z_openloop
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates obejects of open loop transfer function in z-domain.
        public void tf_z_openloop()
        {
            //Creates open loop tf in z domain using tf of machine, controller and electrical.
            tf_machine();
            tf_controller();
            tf_electrical();
        }
        /// ************************* METHOD *************************
        /// Method    : tf_z_closedloop
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates obejects of closed loop transfer function in z-domain.
        public void tf_z_closedloop()
        {
            //Creates open loop tf in z domain using tf of machine, controller, electrical and feedback.
            tf_machine();
            tf_controller();
            tf_electrical();
            feed_back();

        }
    }
    /// ************************* CLASSES *************************
    /// Class       : stability_analysis
    /// Description : Contains methods for creating nyquist plots, FRF(bode plots) and finding gain, phase , stability margins
    ///               Inherits tf_openloop class.
    class stability_analysis :tf_openloop
    {
        /// ************************* METHOD *************************
        /// Method    : nyquist_plot
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates nyquist_plot from open loop tf.
        public void nyquisit_plot()
        {
            //Nyquist stability criteria allows us to asses the relative stability of the systems from the
            //frequency response plots(Bode or Nyquist diagrams) of the open loop system alone, instead of
            //finding the roots of characteristic equation of the closed loop system.
        }
        /// ************************* METHOD *************************
        /// Method    : stability_of_closedloop_system
        /// Arguments : None
        /// Returns   : Nothing
        /// This method checks the stability of the closed loop system by analysing the open loop nyquist.
        public void stability_of_closedloop_system()
        {
            nyquisit_plot();
            //When the Nyquist plot crosses -1,the phase lag will be exactly -180 degrees.
            //This corresponds to a unity gain(or 0dB in log scale) and -180 degree in Bode plot.
            //At this point,the gain and phase margins are zero, and the closed loop poles
            //have no real part and only have complex parts
            //We can just use Z = N + P for checking the stability of system, Z: no.of zeros in 
            //righthand plane of imaginary axis, P : no.of poles; N: no.of counter clock wise encirclements.
            //For a stable system we need 0 zeroes in the RPH; P = -N ==> for every pole the nyquist
            //must do a CCW rotation, anything less than that indicates a zero in RHP making the system unstable.

        }
        /// ************************* METHOD *************************
        /// Method    : stability_margin
        /// Arguments : None
        /// Returns   : Nothing
        /// This method finds the stability margin of nyquist plot.
        public void stability_margin()
        {
            nyquisit_plot();
        }
        /// ************************* METHOD *************************
        /// Method    : bode_plot
        /// Arguments : None
        /// Returns   : Nothing
        /// This method plots the bode plot of the system from magnitude and phase values at diffeent frequencies.
        public void bode_plot()
        {
            //Graphical representation of magnitude and phase of the system.
        }
        /// ************************* METHOD *************************
        /// Method    : gain_margin
        /// Arguments : None
        /// Returns   : Nothing
        /// This method finds the gain margin from the bode plot.
        public void gain_margin()
        {
            //The frequency, where phase becomes -180 deg is called phase crossover frequency,
            //The difference between the gain at phase crosing fequency and 0dB is called gain margin.
            // Gain margin indicates amount of gain increase before making the system critically stable.
            bode_plot();
        }
        /// ************************* METHOD *************************
        /// Method    : phase_margin
        /// Arguments : None
        /// Returns   : Nothing
        /// This method finds the phase margin from the bode plot.
        public void phase_margin()
        {
            //The frequency, where the magnitude becomes 0 is called gain cross over frequency,
            //The difference between the phase at gain cross over frequency and -180 degrees is called phase margin.
            //If the phase is below -180 degree at gain cross over then system is already unstable.
            //Larger the phase margin is, further the system is away from the instability.
            bode_plot();
        }
    }
    /// ************************* CLASSES *************************
    /// Class       : controller_design
    /// Description : Contains methods for designing Proportional controller, PID(proportionl intergral
    ///               and derivative) cotroller and lead lag; Inherits tf_s_to_z class.             
    class controller_design :tf_s_to_z
    {
        /// ************************* METHOD *************************
        /// Method    : p_controller_z_domain
        /// Arguments : None
        /// Returns   : Nothing
        /// This method acounts for proportional controller design in z-domain
        public void p_controller_z_domain()
        {
            tf_z_openloop();
            tf_z_closedloop();
            //Returns Kp:Proportional gain for the controller
        }
        /// ************************* METHOD *************************
        /// Method    : pid_controller_z_domain
        /// Arguments : None
        /// Returns   : Nothing
        /// This method acounts for pid controller design in z-domain
        public void pid_controller_z_domain()
        {
            pid_controller_z_domain();
            //Uses Kp, Ki:Integral gain, Kd:Derivative gain to create a 
            //PID controller; Steps to tune PID
            //Obtain the open loop transfer function of the system to be controlled.
            //Add a proportional control to improve the rise time
            //Add a derivative control to improve the overshoot
            //Add an integral control to remove the steady state error
            //Adjust the gains (Kp;Kd;Ki ) until you are satisfied with the response(i.e.step response)
        }
        /// ************************* METHOD *************************
        /// Method    : lead_lag_compensator
        /// Arguments : None
        /// Returns   : Nothing
        /// This method acounts for lead-lag controller design in z-domain
        public void lead_lag_compensator()
        {
            //controller C(s) = (1+alpha*T*s)/(1+T*s)
            //alpha = (1+sin(phi))/(1-sin(phi))
            //T = 1/Wn*sqrt(alpha)
        }
    }
    
}
namespace state_space_model
{
    /// ************************* USINGS *************************
    using control_systems;
    /// ************************* CLASSES *************************
    /// Class       : state_space_model
    /// Description : Contains methods for state_space_model,state_equation and output_equation.
    ///               Inherits tf_closedloop.
    class state_space_model :tf_closedloop
    {
        /// ************************* METHOD *************************
        /// Method    : state_space_model
        /// Arguments : None
        /// Returns   : Nothing
        /// This method is a constructor for state_space_model objects.
        public state_space_model()
        {
            state_equation();
            output_equation();
        }
        /// ************************* METHOD *************************
        /// Method    : state_equation
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates the state equation.
        public virtual void state_equation()
        {
            //{Xdot(t)} = [A]*{X(t)} + [B]*{U(t)}
            //(complex-matrix multiplication and complex_matrix addition methods are used)
            //Where Xdot is state equation vector
            //[A] : (n x n) State transition matrix containing system dynamics
            //{X} : (n x 1) State vector containing system variables
            //[B] : (n x p) Input Transition matrix which relate the input to the system dynamics
            //{U} : (p x 1) Input vector containing external inputs to the system

        }
        /// ************************* METHOD *************************
        /// Method    : output_equation
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates the output equation.
        public void output_equation()
        {
            //{Y(t)} = [C]*{X(t)} + [D]*{U(t)}
            //Where {Y} is the output equation vector
            //[C] : (q x n) Output transition matrix
            //{X} : (n x 1) State vector containing system variables
            //[D] : (q x p) Input transmission matrix
            //{U} : (p x 1) Input vector containing external inputs to the system
        }
    }
    /// ************************* CLASSES *************************
    /// Class       : state_space_model
    /// Description : Contains methods for discrete_state_space_model,override method for state_equation and discrete_output.
    ///               Inherits state_space_model.
    class discrete_state_space : state_space_model
    {
        /// ************************* METHOD *************************
        /// Method    : discrete_state_space
        /// Arguments : None
        /// Returns   : Nothing
        /// This method is a constructor for discrete_state_space objects.
        public discrete_state_space()
        {
            state_equation();
            output_equation();
        }
        /// ************************* METHOD *************************
        /// Method    : override state_equation
        /// Arguments : None
        /// Returns   : Nothing
        /// This method overrides the state_equation method from the base class.This new state equation gives 
        /// the future state of a system based on the past and present states.
        public override void state_equation()
        {
            //X(k + 1) = phi(T)X(k) + H(T)*U(k)
            //(complex-matrix multiplication and complex_matrix addition methods are used)
            //Where Xdot is state equation vector
            //[phi] : (n x n) State transition matrix containing system dynamics
            //{X} : (n x 1) State vector containing system variables
            //[H] : (n x p) Input Transition matrix which relate the input to the system dynamics
            //{U} : (p x 1) Input vector containing external inputs to the system
        }
        /// ************************* METHOD *************************
        /// Method    : discrete_output
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates the output equation.
        public void discrete_output()
        {
            output_equation();
        }

    }
}
namespace cryptography
{
    /// ************************* CLASSES *************************
    /// Class       : encryption
    /// Description : Contains methods for encrypting a message from user given as key.
    class encryption
    {
        /// ************************* METHOD *************************
        /// Method    : get_private_variables
        /// Arguments : None
        /// Returns   : Nothing
        /// This method gets variables form the complex number class as they are not directly acesible.
        public int get_private_variables()
        {
            /*This method gets the private variables from the complex_matrix class,
             *This allows the accebility to the methods in complex_matrix without altering them.
             */
            int private_variable = 1;
            return private_variable;
        }
        /// ************************* METHOD *************************
        /// Method    : key
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates a complex_matrix that stores the input message from the user.
        public static complex_matrix key()
        {
            /* This method will take in the input data from user for key, 
             * That data will be converted into key matrix.
             * Tough the class is public we cannot access the data.
             * As the variables are private in the complex_matrix class.
             * This is an example of data hiding.
             * Getter property is used to access the variables to create complex matrix.
             */
            return key();
        }
        /// ************************* METHOD *************************
        /// Method    : encryption_matrix
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates a complex_matrix that is the encryption of the key matrix.
        public static complex_matrix encryption_matrix()
        {
            /* This method will take in the input message from user as string, 
             * This message is converted into a encrypted matrix
             * As the complex_matrix is protected,
             * getter property is used to access the method to create complex matrix.
             */
            return encryption_matrix();
        }
        /// ************************* METHOD *************************
        /// Method    : string override method
        /// Arguments : None
        /// Returns   : Nothing
        /// This method is used for the the user input to be displayed after entry to verify.
        public override string ToString()
        {
            /* This method will override the complex matrix into string, 
             * The method will return the encrypted/decrypted string.
             * This is an example of method overriding.
             */
            return base.ToString();
        }
    }
    /// ************************* CLASSES *************************
    /// Class       : decryption
    /// Description : Contains methods for decryptinge the encrypted message and printing the message.
    ///               Inherits the encryption class.
    class decryption : encryption
    {
        /// ************************* METHOD *************************
        /// Method    : decryption_matrix
        /// Arguments : None
        /// Returns   : Nothing
        /// This method creates a complex_matrix that is the decryption of the encropted message.
        public static complex_matrix decryption_matrix()
        {
            /* This method decrypt the message recieved at user end, 
             * This message is displayed for the user.
             */
            return decryption_matrix();
        }
        /// ************************* METHOD *************************
        /// Method    : print_message
        /// Arguments : None
        /// Returns   : Nothing
        /// This method prints the output of the decrypted message to the console for the user to read.
        public void print_message()
        {
            //Sting override method also need to accessed by this class.
        }
    }
}
