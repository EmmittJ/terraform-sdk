using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_security_policy.
/// </summary>
public class AwsOpensearchserverlessSecurityPolicyDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessSecurityPolicyDataSource(string name) : base("aws_opensearchserverless_security_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_date");
        SetOutput("description");
        SetOutput("last_modified_date");
        SetOutput("policy");
        SetOutput("policy_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("type");
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
    /// Name of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Type of security policy. One of `encryption` or `network`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The date the security policy was created.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// Description of the security policy.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The date the security policy was last modified.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

    /// <summary>
    /// The JSON policy document without any whitespaces.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// Version of the policy.
    /// </summary>
    public TerraformExpression PolicyVersion => this["policy_version"];

}
