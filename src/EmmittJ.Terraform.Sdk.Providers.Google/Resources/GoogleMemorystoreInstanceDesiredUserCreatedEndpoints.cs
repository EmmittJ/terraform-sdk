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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the Memorystore instance these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the region of the Memorystore instance these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for desired_user_created_endpoints.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleMemorystoreInstanceDesiredUserCreatedEndpointsDesiredUserCreatedEndpointsBlock>? DesiredUserCreatedEndpoints
    {
        get => GetProperty<List<GoogleMemorystoreInstanceDesiredUserCreatedEndpointsDesiredUserCreatedEndpointsBlock>>("desired_user_created_endpoints");
        set => this.WithProperty("desired_user_created_endpoints", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMemorystoreInstanceDesiredUserCreatedEndpointsTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMemorystoreInstanceDesiredUserCreatedEndpointsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
