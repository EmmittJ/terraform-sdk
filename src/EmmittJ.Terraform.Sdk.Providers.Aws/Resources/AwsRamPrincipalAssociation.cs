using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ram_principal_association resource.
/// </summary>
public class AwsRamPrincipalAssociation : TerraformResource
{
    public AwsRamPrincipalAssociation(string name) : base("aws_ram_principal_association", name)
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
    /// The principal attribute.
    /// </summary>
    public TerraformProperty<string>? Principal
    {
        get => GetProperty<TerraformProperty<string>>("principal");
        set => this.WithProperty("principal", value);
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
    /// The resource_share_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceShareArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_share_arn");
        set => this.WithProperty("resource_share_arn", value);
    }

}
