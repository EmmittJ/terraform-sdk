using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ebs_default_kms_key resource.
/// </summary>
public class AwsEbsDefaultKmsKey : TerraformResource
{
    public AwsEbsDefaultKmsKey(string name) : base("aws_ebs_default_kms_key", name)
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
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    public required TerraformProperty<string> KeyArn
    {
        get => GetProperty<TerraformProperty<string>>("key_arn");
        set => this.WithProperty("key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
