# MustafaEraslanOdev2
MVCWebAPIWithoutDb

Hello coder,

I have completed my dotnetcore WebApi project that meets the requirements in the subsection.

Requirements:
There will be at least 2 different web api controllers (in one project). One will handle the participants' processes, the other the admin functions. Rest standards should be considered.
No UI, just api.
--BootCampApiController
-List Bootcamp (Active/Past)
-Bring Bootcamp
-Join Bootcampe
-more limited only by your imagination

--AdminApiController
-Save Bootcamp
-Delete Bootcamp
-Confirm Participant
-Delete Participant
-more limited only by your imagination

I used 2 controllers in my project. One of them is "AdminApiCotroller" and the other is "BootCampApiController"

I coded the methods that provide CRUD operations for both controllers.

I put the one that does the common work for the 2 controllers in the folder named "Helper". I created IBootcampService.cs, DictionaryHelper.cs, BootcampService.cs in this folder.
I defined my parameters with Get Set.

I coded BootcampEntitiy.cs, ParticipantEntity.cs, ServisResponse.cs with Entities folder.
I generated code for Bootcamp using the Guid structure with BootcampEntity.cs. I have defined the bootcamp domains. Added Name and Description.
I added the parameters of the participants with ParticipantEntity.cs. Added "Guid Id", "Name", "Surname", "Phone".
With ServiceResponse.cs, I managed to return an error message when the endpoint is not responding.

And finally, with swagger, my API project was up and running.

Kind regards,
Mustafa
