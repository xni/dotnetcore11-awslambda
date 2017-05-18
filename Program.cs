using System;
using System.IO;
using Amazon.Lambda.Core; 

namespace CSharpLambdaFunction
{
    public class LambdaHandler
    {
        public string MyHandler(int counter, ILambdaContext context) {
            var logger = context.Logger;
            logger.Log("received : " + counter);
            return "hey, I just met you";
        }
    }
}
