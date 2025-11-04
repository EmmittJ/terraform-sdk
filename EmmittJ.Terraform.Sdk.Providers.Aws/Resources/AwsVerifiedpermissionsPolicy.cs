using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedpermissions_policy resource.
/// </summary>
public class AwsVerifiedpermissionsPolicy : TerraformResource
{
    public AwsVerifiedpermissionsPolicy(string name) : base("aws_verifiedpermissions_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date");
        this.DeclareOutput("id");
        this.DeclareOutput("policy_id");
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    public string? PolicyStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_store_id")?.Value;
        set => this.WithProperty("policy_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformExpression PolicyId => this["policy_id"];

}
