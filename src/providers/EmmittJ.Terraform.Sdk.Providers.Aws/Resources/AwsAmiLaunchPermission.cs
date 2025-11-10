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
        SetOutput("account_id");
        SetOutput("group");
        SetOutput("id");
        SetOutput("image_id");
        SetOutput("organization_arn");
        SetOutput("organizational_unit_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string> Group
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group");
        set => SetProperty("group", value);
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
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    public required TerraformProperty<string> ImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_id");
        set => SetProperty("image_id", value);
    }

    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    public TerraformProperty<string> OrganizationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization_arn");
        set => SetProperty("organization_arn", value);
    }

    /// <summary>
    /// The organizational_unit_arn attribute.
    /// </summary>
    public TerraformProperty<string> OrganizationalUnitArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organizational_unit_arn");
        set => SetProperty("organizational_unit_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
