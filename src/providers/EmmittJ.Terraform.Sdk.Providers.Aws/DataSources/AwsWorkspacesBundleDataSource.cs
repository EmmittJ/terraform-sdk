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
        SetOutput("compute_type");
        SetOutput("description");
        SetOutput("root_storage");
        SetOutput("user_storage");
        SetOutput("bundle_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("owner");
        SetOutput("region");
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformProperty<string> BundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bundle_id");
        set => SetProperty("bundle_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string> Owner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner");
        set => SetProperty("owner", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
