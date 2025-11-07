using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ami_launch_permission resource.
/// </summary>
public class AwsAmiLaunchPermission : TerraformResource
{
    public AwsAmiLaunchPermission(string name) : base("aws_ami_launch_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_id");
        set => this.WithProperty("image_id", value);
    }

    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrganizationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_arn");
        set => this.WithProperty("organization_arn", value);
    }

    /// <summary>
    /// The organizational_unit_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrganizationalUnitArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organizational_unit_arn");
        set => this.WithProperty("organizational_unit_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
