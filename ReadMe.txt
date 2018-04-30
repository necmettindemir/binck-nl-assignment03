

----------------------------------------------

Assignment

3) Assume, you’re asked to create a simple REST API for a CRM system. 
   Please describe what you would do and draft the API.


----------------------------------------------

Assumptions

1. It is supposed that the REST API for such a system will be developed in C#, 
   Microsoft Visual Studio 201x.
   (Of course, this REST API could be developed in many IDEs such as NetBeans or Eclipse using Java, Zend using PHP, etc)



2. For the simplicity of explanation, only basic CRUD operations are mentioned.

   For example 

	- Add  (INSERT) customer (POST)
	- List (SELECT) customer (GET)
	- Upd  (UPDATE) customer (PUT)
	- Del  (DELETE) customer (DELETE)


3. It is supposed that any client (web, win, mobile, etc) can make request
   from any IP without any restrictions.


4. It is supposed that the REST API runs under SSL.
   https://...

----------------------------------------------


Solution for REST API


1) Type of Data

First of all, although XML can be used, all REST methods could be designed to get and return JSON data.


2) Consideration of Limitation in Data Flow

   Especially for list requests the limitation of communication with http should be considered.
   It means that our API must guarantee not to fail because of lots of data in resultset.


3) Logging and Locking

   All request must be logged. 
   It means that Who, When, Where, What, Why, How, etc should be answered in any situation that should be investigated.

   If we are handling sensitive operations we can design a lock mechanism for some fraud-smelling requests.

   For example;
   After 5 failed operations the REST client account can be locked for 3 hours. 


4) Security

   Although from the view of security many techniques could be performed,
   an API KEY mechanism can be desgined. 
   This approach would be better than using sensitive authentication keys in request header.

   In this scenario 

   - A message handler class can be designed
   - In Global.asax this handler can be used


   If we have to use authentication keys in request, encryption and encoding will help us.
 
   Moreover some more advanced authenticatin mechanism can be desinged according to requirements such as OAuth, NTLM, etc.

   For this topic an example application as rest server and rest client are added to this assignent.



5) Some Example Client Applications in Other Langugaes

   If we are developing REST API it means we are developing a programmatic interface for developers.
   These developers could be developers of our possible customers or our developers.

   In both cases we should develop some example REST client applications in other popular languages or platforms.   
   It means that REST client examples in c#, php, java, react, react native, etc should be prepared under the name of "The Example Clients".

   - This approach would help developers who are not familiar to REST communication.
   - We develop REST API for integration. By this way necessary integration would be performed faster.
   

6) Documentation

   Builtin documentation should be prepared for other developers


7) Test Server

   For better integration process, address of a TEST REST Server can be given to developers with REAL REST Server.
   Such an approach will make us to have clearer data in real system.


----------------------------------------------


Technical Design for REST API

LookAtMe_Prj03_CRM_REST_API.png





