using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_framework_share resource.
/// </summary>
public class AwsAuditmanagerFrameworkShare : TerraformResource
{
    public AwsAuditmanagerFrameworkShare(string name) : base("aws_auditmanager_framework_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("status");
        SetOutput("comment");
        SetOutput("destination_account");
        SetOutput("destination_region");
        SetOutput("framework_id");
        SetOutput("region");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The destination_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationAccount is required")]
    public required TerraformProperty<string> DestinationAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_account");
        set => SetProperty("destination_account", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRegion is required")]
    public required TerraformProperty<string> DestinationRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_region");
        set => SetProperty("destination_region", value);
    }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkId is required")]
    public required TerraformProperty<string> FrameworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("framework_id");
        set => SetProperty("framework_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
