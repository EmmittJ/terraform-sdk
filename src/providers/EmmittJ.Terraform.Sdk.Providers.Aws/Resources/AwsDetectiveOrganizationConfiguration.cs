using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_detective_organization_configuration resource.
/// </summary>
public class AwsDetectiveOrganizationConfiguration : TerraformResource
{
    public AwsDetectiveOrganizationConfiguration(string name) : base("aws_detective_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_enable");
        SetOutput("graph_arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformProperty<bool> AutoEnable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_enable");
        set => SetProperty("auto_enable", value);
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    public required TerraformProperty<string> GraphArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("graph_arn");
        set => SetProperty("graph_arn", value);
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

}
