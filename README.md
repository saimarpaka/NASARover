# NASARover
The inputs are first validated to be in the specific format. 
It is assumed that the bounds that are entered initially should not be crossed.
After the inputs have been validated, the application proceeds to execute instructions in the order they were received in.
The Rover class is the instance of the Rover and its components which allow it to Turn and Navigate are added to it as properties.
The Navigate method of the Rover is whats used to control the Rover navigation, and it performs actions such as turning left or right, and moving
in the direction specified.
The RoverRotator class uses a LinkedList with an extention method, which is used to return either the First or the Last element of the linked 
list whenever turns are being triggered. This not only helps prevent redundant code, but allows easier turn management.
After all the instructions are executed in the order they were received in, the final positions are printed out.
