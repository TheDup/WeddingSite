using UI.Wedding.Constants;
using static UI.Wedding.Constants.RSVP;

namespace UI.Wedding.DTO
{
    public record guest
    {
        string firstName;
        string lastName;
        RSVP rsvp;
        DateTime decisionTimeStamp;
        string cellNumber;
    }
}
