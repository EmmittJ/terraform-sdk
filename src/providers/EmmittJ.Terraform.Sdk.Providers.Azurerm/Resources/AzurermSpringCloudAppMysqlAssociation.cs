using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudAppMysqlAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppMysqlAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_app_mysql_association Terraform resource.
/// Manages a azurerm_spring_cloud_app_mysql_association resource.
/// </summary>
public partial class AzurermSpringCloudAppMysqlAssociation(string name) : TerraformResource("azurerm_spring_cloud_app_mysql_association", name)
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mysql_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MysqlServerId is required")]
    public required TerraformValue<string> MysqlServerId
    {
        get => new TerraformReference<string>(this, "mysql_server_id");
        set => SetArgument("mysql_server_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudAppMysqlAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudAppMysqlAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
