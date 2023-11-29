namespace TuklasTalinoService.Users
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/login/{id}", HandleLogin);

            endpoints.MapPost("/register", HandleRegister);
        }

        public static async Task HandleLogin()
        {

        }

        public static async Task HandleRegister()
        {

        }
    }
}
