using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization.
/// </summary>
public class GoogleOrganizationDataSource : TerraformDataSource
{
    public GoogleOrganizationDataSource(string name) : base("google_organization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("directory_customer_id");
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("name");
        this.DeclareOutput("org_id");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public string? Organization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization")?.Value;
        set => this.WithProperty("organization", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The directory_customer_id attribute.
    /// </summary>
    public TerraformExpression DirectoryCustomerId => this["directory_customer_id"];

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformExpression OrgId => this["org_id"];

}
