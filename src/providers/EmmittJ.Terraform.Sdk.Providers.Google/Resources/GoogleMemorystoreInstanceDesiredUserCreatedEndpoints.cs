using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for desired_user_created_endpoints in .
/// Nesting mode: list
/// </summary>
public class GoogleMemorystoreInstanceDesiredUserCreatedEndpointsDesiredUserCreatedEndpointsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMemorystoreInstanceDesiredUserCreatedEndpointsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_memorystore_instance_desired_user_created_endpoints resource.
/// </summary>
public class GoogleMemorystoreInstanceDesiredUserCreatedEndpoints : TerraformResource
{
    public GoogleMemorystoreInstanceDesiredUserCreatedEndpoints(string name) : base("google_memorystore_instance_desired_user_created_endpoints", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name of the Memorystore instance these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The name of the region of the Memorystore instance these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for desired_user_created_endpoints.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleMemorystoreInstanceDesiredUserCreatedEndpointsDesiredUserCreatedEndpointsBlock>? DesiredUserCreatedEndpoints
    {
        set => SetProperty("desired_user_created_endpoints", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMemorystoreInstanceDesiredUserCreatedEndpointsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
