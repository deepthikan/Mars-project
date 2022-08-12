Feature: ProfileFeature
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

Background: 
   Given seller logged in to Mars portal successfully
	When seller navigate to Profile page

@tag1
Scenario:Seller is able to add description on the Profile.
	Given seller provides the description as "My name is Jade i love hiking and baking during my leisure time"
	Then The description details should be added successfully

Scenario:Seller is able to edit description on the Profile.
	Given seller edits the description as "My name is Jade Rose i love hiking and baking during my leisure time"
	Then The description details should be added successfully

Scenario:Seller is able to delete description on the Profile.
	Given seller deletes the description 
	Then Error message "Please, a description is required" should be displayed

Scenario Outline:Verify validation error for Description field 
	Given seller tries to enter special characters or left it as blank
	Then Following error messages should be displayed

	Examples: 
	| Description | Error message                                |
	| @$&         | First character can only be digit or letters |
	|             | "Please, a description is required"          |

	
Scenario Outline:Seller is able to add Languages on the Profile 
	
	Given seller add new '<Languages>' and '<Level>' on profile
	Then The'<Languages>' details should be added successfully
	
	Examples: 
	| Languages | Level            |
	| French    | Conversational   |
	| English   | Native/Bilingual |

Scenario Outline:Seller is able to edit Languages on the Profile
	
	Given seller edit existing '<Languages>' and '<Level>' on profile
	Then The'<Languages>' should be updated successfully
	
	Examples: 
	| Languages | Level |
	| Spanish   | Basic |

Scenario:Seller is able to delete Languages on the Profile
	Given seller deletes existing languages on profile
	Then The languages should be deleted successfully


Scenario: Verify validation error for Languages tab
	Given Seller left languages field as blank
	Then Following error message should be displayed "Please enter language and level"


Scenario Outline:Seller is able to add Skills details.
	Given seller add new '<Skills>' and '<Level>' on profile
	Then '<Skills>' should be added successfully

	Examples: 
	| Skills  | Level        |
	| Baking  | Intermediate |
	| Editing | Intermediate |

Scenario Outline:Seller is able to edit Skills details.
	
	Given seller edits existing '<Skills>' and '<Level>' on profile
	Then '<Skills>' should be updated successfully

	Examples: 
	| Skills  | Level        |
	| Baking  | Expert       |
	| Editing | Expert       |
	| SEO     | Intermediate |

Scenario: Seller is able to delete Skills details.
	Given seller deletes existing Skills
	Then Skills should be deleted successfully


Scenario: Verify validation error for Skills tab
	Given Seller left Skills field as blank
	Then Following error message should be displayed "Please enter skill and experience level"

Scenario Outline: Seller is able to add Education details.
	
	Given seller add education as follows '<CollegeName>', '<Title>','<Degree>','<Year>' and '<Country>'
	Then Education details should be added successfully

	Examples: 
	| CollegeName | Title  | Degree | Year | Country |
	| AUT         | B.Tech | I.T    | 2009 | India   |

Scenario Outline: Seller is able to edit Education details.
	
	Given seller edits existing education as follows '<CollegeName>', '<Title>','<Degree>','<Year>' and '<Country>'
	Then Education details should be updated succesfully

	Examples: 
	| CollegeName | Title  | Degree | Year | Country     |
	| AUT         | M.Tech | I.T    | 2012 | New Zealand |

Scenario: Seller is able to delete Education details.
	Given seller deletes existing education details
	Then Education details should be deleted successfully

Scenario: Verify validation error for Education tab
	Given Seller left Education field as blank
	Then Following error message should be displayed "Please enter all the fields"


Scenario Outline: Seller is able to add the Certifications details.
	
	Given seller add new '<Certifications>', '<CertificateFrom>' and '<Year>' to profile
	Then The '<Certifications>' details should be added successfully

	Examples: 
	| Certifications   | CertificateFrom | Year |
	| Istqb Foundation | ISTQB           | 2020 |
	| Baking Basics    | Bake Goods      | 2019 |

Scenario Outline: Seller is able to edit the Certifications details.
	
	Given seller edits existing '<Certifications>', '<CertificateFrom>' and '<Year>' to profile
	Then '<Certifications>' details should be updated successfully

	Examples: 
	| Certifications | CertificateFrom | Year |
	| Istqb Advance  | ISTQB           | 2022 |
	| Baking  Pro    | Bake Goods      | 2021 |

Scenario: Seller is able to delete Certifications details.
	Given Seller deletes Certifications details
	Then Certifications details should be deleted successfully

Scenario: Verify validation error for Certifications tab.
	Given Seller left Certifications field as blank
	Then Following error message should be displayed "Please enter Certification Name, Certification From and Certification Year"

Scenario Outline: Seller is able to add the Availability on profile 
	
	Given seller add '<Availability>','<Hours>' and '<Earn Target>' to profile details
	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully

	Examples: 
	| Availability | Hours                    | Earn Target                      |
	| Part Time    | Less than 30hours a week | Between $500 and $1000 per month |


Scenario Outline: Seller is able to edit the Availability on profile 
	
	Given seller edits '<Availability>','<Hours>' and '<Earn Target>' to profile details
	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully

	Examples: 
	| Availability | Hours                    | Earn Target               |
	| Full Time    | More than 30hours a week | More than $1000 per month |







	 
