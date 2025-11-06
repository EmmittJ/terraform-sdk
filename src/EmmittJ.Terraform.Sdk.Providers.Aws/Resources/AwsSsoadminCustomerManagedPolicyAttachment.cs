using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_customer_managed_policy_attachment resource.
/// </summary>
public class AwsSsoadminCustomerManagedPolicyAttachment : TerraformResource
{
    public AwsSsoadminCustomerManagedPolicyAttachment(string name) : base("aws_ssoadmin_customer_managed_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The instance_arn attribute.
    /// </summary>
    public string? InstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_arn")?.Value;
        set => this.WithProperty("instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    public string? PermissionSetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission_set_arn")?.Value;
        set => this.WithProperty("permission_set_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
