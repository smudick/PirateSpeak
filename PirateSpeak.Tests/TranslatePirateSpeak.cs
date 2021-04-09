using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeak.Tests
{
    public class TranslatePirateSpeak
    {
        [Fact]
        public void when_arr_is_passed_in_then_arr_should_be_returned()
        {
            //Arrange
            string pirateSpeak = "arr";

            var pirateWordsArray = new List<string>() { "boat", "arr", "flag" };

            var translator = new PirateSpeakTranslator();
            //Act
            var result = translator.PirateToEnglish(pirateSpeak, pirateWordsArray);
            //Assert
            Assert.Equal(new List<string> { "arr" }, result);
        }
        [Fact]
        public void when_ship_is_passed_in_then_hips_should_be_returned()
        {
            //Arrange
            string pirateSpeak = "ship";

            var pirateWordsArray = new List<string>() { "hips", "boat", "car" };

            var translator = new PirateSpeakTranslator();
            //Act
            var result = translator.PirateToEnglish(pirateSpeak, pirateWordsArray);
            //Assert
            Assert.Equal(new List<string> { "hips" }, result);
        }
        [Fact]
        public void when_ship_is_passed_in_then_hips_and_pish_should_be_returned()
        {
            //Arrange
            string pirateSpeak = "ship";

            var pirateWordsArray = new List<string>() { "hips", "boat", "car", "pish" };

            var translator = new PirateSpeakTranslator();
            //Act
            var result = translator.PirateToEnglish(pirateSpeak, pirateWordsArray);
            //Assert
            Assert.Equal(new List<string>{"hips","pish"}, result);
        }
        [Fact]
        public void when_ortsp_is_passed_in_then_sports_and_ports_should_be_returned()
        {
            //Arrange
            string pirateSpeak = "ortsp";

            var pirateWordsArray = new List<string>() { "sport", "parrot", "ports", "matey" };

            var translator = new PirateSpeakTranslator();
            //Act
            var result = translator.PirateToEnglish(pirateSpeak, pirateWordsArray);
            //Assert
            Assert.Equal(new List<string>{"sport","ports"}, result);
        }
    }
}
