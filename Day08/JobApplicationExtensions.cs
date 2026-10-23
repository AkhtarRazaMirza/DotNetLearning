public static class JobApplicationExtensions
{
    /// <summary>
    /// Extension method to check whether a JobApplication has a particular status.
    /// Supports case-insensitive comparison.
    /// </summary>
    public static bool HasStatus(this JobApplication application, string status)
    {
        if (application == null)
        {
            return false;
        }

        return string.Equals(application.Status, status, StringComparison.OrdinalIgnoreCase);
    }
}
