using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<string>? Org
    {
        get => GetProperty<TerraformProperty<string>>("org");
        set => this.WithProperty("org", value);
    }

}
