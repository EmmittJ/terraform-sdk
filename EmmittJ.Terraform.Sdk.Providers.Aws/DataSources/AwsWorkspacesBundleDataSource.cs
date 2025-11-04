using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_bundle.
/// </summary>
public class AwsWorkspacesBundleDataSource : TerraformDataSource
{
    public AwsWorkspacesBundleDataSource(string name) : base("aws_workspaces_bundle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("compute_type");
        this.DeclareOutput("description");
        this.DeclareOutput("root_storage");
        this.DeclareOutput("user_storage");
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public string? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id")?.Value;
        set => this.WithProperty("bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public string? Owner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner")?.Value;
        set => this.WithProperty("owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformExpression ComputeType => this["compute_type"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The root_storage attribute.
    /// </summary>
    public TerraformExpression RootStorage => this["root_storage"];

    /// <summary>
    /// The user_storage attribute.
    /// </summary>
    public TerraformExpression UserStorage => this["user_storage"];

}
