Feature: ProfileFeature

As a I
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

Background: 
   Given I logged in to Mars portal successfully
	When I navigate to Profile page

Scenario Outline:01 Seller is able to add Skills details.
	Given I add new '<Skills>' and '<Level>' on profile
	Then '<Skills>' and '<Level>' should be added successfully

	Examples: 
	| Skills  | Level        |
	| Baking  | Intermediate |
	| Editing | Beginner     |

Scenario Outline:02 Seller is able to edit Skills details.
	
	Given I edit existing '<Skills>' and '<Level>' on profile
	Then '<Skills>' and '<Level>' should be updated successfully

	Examples: 
	| Skills | Level  |
	| Baking | Expert |
	
Scenario:03 Seller is able to delete Skills details.
	Given I delete existing Skills
	Then Skills should be deleted successfully


Scenario:04 Verify validation error for Skills tab
	Given I left Skills field as blank
	Then error message should be displayed 

Scenario Outline:05 Seller is able to add Education details.
	
	Given I add education as follows '<CollegeName>','<Country>','<Title>','<Degree>' and '<Year>' 
	Then '<CollegeName>','<Country>','<Title>','<Degree>' and '<Year>'  details should be added successfully

	Examples: 
	| CollegeName | Country     | Title  | Degree | Year |
	| AUT         | New Zealand | B.Tech | I.T    | 2009 |

Scenario Outline:06 Seller is able to edit Education details.
	
	Given I edit existing education as follows '<CollegeName>','<Country>','<Title>','<Degree>' and '<Year>'
	Then '<CollegeName>','<Country>','<Title>','<Degree>' and '<Year>' details should be updated succesfully

	Examples: 
	| CollegeName | Country | Title  | Degree | Year |
	| JNTU        | India   | M.Tech | I.T    | 2012 |

Scenario:07 Seller is able to delete Education details.
	Given I delete existing education details
	Then Education details should be deleted successfully

Scenario:08 Verify validation error for Education tab
	Given I left Education field as blank
	Then Education error message should be displayed


Scenario Outline:09 Seller is able to add the Certifications details.
	
	Given I add new '<Certifications>','<CertificateFrom>' and '<Year>' to profile
	Then The '<Certifications>','<CertificateFrom>' and '<Year>'details should be added successfully

	Examples: 
	| Certifications   | CertificateFrom | Year |
	| Istqb Foundation | ISTQB           | 2020 |
	| Baking Basics    | Bake Goods      | 2019 |

Scenario Outline:10 Verify seller is able to edit the Certifications details.
	
	Given I edit existing '<Certifications>','<CertificateFrom>' and '<Year>' to profile
	Then '<Certifications>','<CertificateFrom>' and '<Year>' details should be updated successfully

	Examples: 
	| Certifications | CertificateFrom | Year |
	| Istqb Advance  | ISTQB           | 2022 |

Scenario:11 Verify Seller is able to delete Certifications details.
	Given I delete Certifications details
	Then Certifications details should be deleted successfully

Scenario:12 Verify validation error for Certifications tab.
	Given I left Certifications field as blank
	Then Following error message should be displayed

#-------------------------------------------------------------------------------------------------------------
#Scenario:Seller is able to add description on profile.
#	Given I provide the description as "My name is Jade i love hiking and baking during my leisure time"
#	Then The description details should be added successfully
#
#Scenario:Seller is able to edit description on the Profile.
#	Given I edit the description as "My name is Jade Rose i love hiking and baking during my leisure time"
#	Then The description details should be added successfully
#
#Scenario:Seller is able to delete description on the Profile.
#	Given I delete the description 
#	Then Error message "Please, a description is required" should be displayed
#
#Scenario Outline:Verify validation error for Description field 
#	Given I try to enter special characters or left it as blank
#	Then Following error messages should be displayed
#
#	Examples: 
#	| Description | Error message                                |
#	| @$&         | First character can only be digit or letters |
#	|             | "Please, a description is required"          |
#
#	
#Scenario Outline:Seller is able to add Languages on the Profile 
#	
#	Given I add new '<Languages>' and '<Level>' on profile
#	Then The'<Languages>' details should be added successfully
#	
#	Examples: 
#	| Languages | Level            |
#	| French    | Conversational   |
#	| English   | Native/Bilingual |
#
#Scenario Outline:Seller is able to edit Languages on the Profile
#	
#	Given I edit existing '<Languages>' and '<Level>' on profile
#	Then The'<Languages>' should be updated successfully
#	
#	Examples: 
#	| Languages | Level |
#	| Spanish   | Basic |
#
#Scenario:Seller is able to delete Languages on the Profile
#	Given I delete existing languages on profile
#	Then The languages should be deleted successfully
#
#
#Scenario: Verify validation error for Languages tab
#	Given I left languages field as blank
#	Then Following error message should be displayed "Please enter language and level"
#

#Scenario Outline: Seller is able to add the Availability on profile 
#	
#	Given I add '<Availability>','<Hours>' and '<Earn Target>' to profile details
#	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully
#
#	Examples: 
#	| Availability | Hours                    | Earn Target                      |
#	| Part Time    | Less than 30hours a week | Between $500 and $1000 per month |
#
#
#Scenario Outline: Seller is able to edit the Availability on profile 
#	
#	Given I edit '<Availability>','<Hours>' and '<Earn Target>' to profile details
#	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully
#
#	Examples: 
#	| Availability | Hours                    | Earn Target               |
#	| Full Time    | More than 30hours a week | More than $1000 per month |







	 
