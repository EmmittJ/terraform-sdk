using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_default_service_account.
/// </summary>
public class GoogleComputeDefaultServiceAccountDataSource : TerraformDataSource
{
    public GoogleComputeDefaultServiceAccountDataSource(string name) : base("google_compute_default_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("display_name");
        this.WithOutput("email");
        this.WithOutput("member");
        this.WithOutput("name");
        this.WithOutput("unique_id");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformExpression Member => this["member"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
