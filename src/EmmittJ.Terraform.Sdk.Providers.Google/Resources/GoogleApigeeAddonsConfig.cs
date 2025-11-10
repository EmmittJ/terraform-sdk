using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeAddonsConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_addons_config resource.
/// </summary>
public class GoogleApigeeAddonsConfig : TerraformResource
{
    public GoogleApigeeAddonsConfig(string name) : base("google_apigee_addons_config", name)
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
    /// Name of the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Org is required")]
    public required TerraformProperty<string> Org
    {
        get => GetProperty<TerraformProperty<string>>("org");
        set => this.WithProperty("org", value);
    }

    /// <summary>
    /// Block for addons_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    public List<GoogleApigeeAddonsConfigAddonsConfigBlock>? AddonsConfig
    {
        get => GetProperty<List<GoogleApigeeAddonsConfigAddonsConfigBlock>>("addons_config");
        set => this.WithProperty("addons_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeAddonsConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeAddonsConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
