using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_access_policy.
/// </summary>
public class AwsOpensearchserverlessAccessPolicyDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessAccessPolicyDataSource(string name) : base("aws_opensearchserverless_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("id");
        this.DeclareOutput("policy");
        this.DeclareOutput("policy_version");
    }

    /// <summary>
    /// Name of the policy.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Type of access policy. Must be `data`.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Description of the policy. Typically used to store information about the permissions defined in the policy.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// JSON policy document to use as the content for the new policy.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// Version of the policy.
    /// </summary>
    public TerraformExpression PolicyVersion => this["policy_version"];

}
