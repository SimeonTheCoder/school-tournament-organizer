| Role        | Read   | Create | Edit | Delete | Enroll |
| ----------- | ------ | ------ | ---- | ------ | ------ |
| Guest       | public |        |      |        |        |
| Participant | own    |        |      |        | *      |
| Organizer   | *      | *      | own  | own    | *      |
| Admin       | *      | *      | *    | *      | *      |

# Guest

- Can see tournaments
- Can see **public** results
- Can look at **public** profiles
# Participant

- Can enroll in tournaments
- Gets stats
	- Separate for each sport
	- Some global ones
- Event timeline

# Organizer

- Can create tournaments
- Can enter results
- Can delete own tournaments
- Can edit own tournaments
- Can kick participants

# Admin

- Editing & Deleting any tournament
- Changing any tournament results
- Can kick participants
- Can delete / ban accounts
- Can change profile types