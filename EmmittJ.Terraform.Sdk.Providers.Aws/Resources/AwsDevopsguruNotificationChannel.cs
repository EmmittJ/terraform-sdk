using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_devopsguru_notification_channel resource.
/// </summary>
public class AwsDevopsguruNotificationChannel : TerraformResource
{
    public AwsDevopsguruNotificationChannel(string name) : base("aws_devopsguru_notification_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
