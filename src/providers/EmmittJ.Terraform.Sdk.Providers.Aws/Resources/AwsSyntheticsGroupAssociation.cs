using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_synthetics_group_association resource.
/// </summary>
public class AwsSyntheticsGroupAssociation : TerraformResource
{
    public AwsSyntheticsGroupAssociation(string name) : base("aws_synthetics_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("group_arn");
        SetOutput("group_id");
        SetOutput("canary_arn");
        SetOutput("group_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The canary_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanaryArn is required")]
    public required TerraformProperty<string> CanaryArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("canary_arn");
        set => SetProperty("canary_arn", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_name");
        set => SetProperty("group_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The group_arn attribute.
    /// </summary>
    public TerraformExpression GroupArn => this["group_arn"];

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformExpression GroupId => this["group_id"];

}
